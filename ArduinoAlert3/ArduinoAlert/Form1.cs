using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;

namespace ArduinoAlert
{

    

    public partial class ArduinoAlert : Form
    {
        public enum ArdunioComState {Idling, Running};

        public int arduino_state = (int)ArdunioComState.Idling;
        public int arduino_connected = 0;
        public PerformanceCounterCategory processorCategory;
        public PerformanceCounter[] countersInCategory;
        public PerformanceCounter performanceCounter;
        PerformanceCounter[] savedCounters;
        PerformanceCounter activeCounter;
        public string global_highthreshold;
        public string comPort;

        public ArduinoAlert()
        {
            InitializeComponent();
            getAvailablePorts();

            //DisplayCategories();

            processorCategory = PerformanceCounterCategory.GetCategories().FirstOrDefault(cat => cat.CategoryName == "Processor");
            countersInCategory = processorCategory.GetCounters("_Total");
            performanceCounter = countersInCategory.First(cnt => cnt.CounterName == "% Processor Time");
            activeCounter = performanceCounter;
            GetCategories();
            
            listBoxCategories.SelectedIndex = listBoxCategories.FindString("Processor");
            instanceListBox.SelectedIndex = instanceListBox.FindString("_Total");
            countersListBox.SelectedIndex = countersListBox.FindString("% Processor Time");
            counterTextBox.Text = activeCounter.CounterName;
            highthreshold_TextBox.Text = "50.0";
            highthreshold_TextBox.ReadOnly = false;

        }

        void getAvailablePorts()
        {
            arduino_connected = 0;
            try {
                string[] ports = SerialPort.GetPortNames();
                COMPortList.Items.Clear();
                if (ports.Length <= 0) throw new Exception("No Serial Port Devices Found! - Check Arduino Connection");
                else {
                    COMPortList.Items.AddRange(ports);
                    COMPortList.SelectedIndex = 0;
                    comPort = COMPortList.SelectedText;
                    portStatusText.Text = "Com Ports Loaded";
                    portStatusText.Visible = true;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message.ToString());
                portStatusText.Text = "No Com Ports Found - Check USB";
                portStatusText.Visible = false;
            }
        }

        private void SendCounter()
        {
            long count = 0;  // counts messages sent from computer to the serial port
            string rx_message;  // message received
            string tx_message;  // message transmitted
            SerialPort aport;

            try {
                aport = new SerialPort(comPort);
                aport.BaudRate = Convert.ToInt32("38400");
                aport.Open();
                arduino_connected = 1;
            }
            catch (Exception e)
            {
                arduino_connected = 0;
                MessageBox.Show(e.Message.ToString());
                return;
            }

            //portStatusText.Text = "Connected to " + COMPortList.Text + " at rate " + aport.BaudRate.ToString();

            // message loop
            while ((arduino_state == (int)ArdunioComState.Running))
            {
                count += 1;
                //var nextval = performanceCounter.NextValue().ToString();
                var nextval = activeCounter.NextValue().ToString();
                if (nextval == "0") nextval = "0.0";

                //Console.WriteLine("Message: " + count.ToString() + ": " + nextval.ToString());
                tx_message = activeCounter.CounterName + "! " +  highthreshold_TextBox.Text.ToString() + " " + nextval;

                // don't write unless arduino has said "READY"
                rx_message = aport.ReadLine();
                if (rx_message == "READY\r")
                {
                      aport.Write(tx_message);
                }
               // System.Threading.Thread.Sleep(150);
       
                /*
                rx_message = aport.ReadLine();
                if (rx_message == "READY\r") { 
                    aport.Write(highthreshold_TextBox.Text);
                }
                */
                System.Threading.Thread.Sleep(500);
            }
            aport.Close();
        }

        // DisplayCategories - Loads the list box with available categories
        private void GetCategories()
        {
            PerformanceCounterCategory[] categories;
            categories = PerformanceCounterCategory.GetCategories();
            for (int i = 0; i < categories.Length; i++)
            {
                listBoxCategories.Items.Add(categories[i].CategoryName);
            
            }
        }

        string query = "*[System/Level=1]";
        
        void read_system_log ()
        {

            EventLog myLog = new EventLog("System");
            foreach (EventLogEntry entry in myLog.Entries)
            {
                if (entry.EntryType == EventLogEntryType.Error || entry.EntryType == 0)
                {
                    string nowis = DateTime.Today.ToString().Substring(0, 10);
                    string logis = entry.TimeWritten.ToString().Substring(0, 10);

                    //if (entry.ToString().Substring(0, 10).Equals(DateTime.Today.ToString().Substring(0,10)))
                    if (nowis.Equals(logis, StringComparison.Ordinal))
                        syslogListBox.Items.Add(entry.TimeWritten.ToString() + ": " + entry.Message);
                }
            }
            
        }

        private void COMPortList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sendGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {

        }

       
        private void startButton_Click(object sender, EventArgs e)
        { 
            if (COMPortList.SelectedIndex >= 0)
               comPort = COMPortList.SelectedItem.ToString();
            else
            {
                MessageBox.Show("Please select a COM port!");
                return;
            }

            if (!(arduino_state == (int)ArdunioComState.Running))
            {
                arduino_state = (int)ArdunioComState.Running;
                portStatusText.Text = "Running";
                new Thread(() =>
               {
                   Thread.CurrentThread.IsBackground = true;
                   SendCounter();
               }).Start();

            }
            highthreshold_TextBox.ReadOnly = true;
            PressStopLabel.Visible = true;
            System.Threading.Thread.Sleep(1000);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            arduino_state = (int)ArdunioComState.Idling;
            portStatusText.Text = "Idling";
            System.Threading.Thread.Sleep(1000);
            highthreshold_TextBox.ReadOnly = false;
            PressStopLabel.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            GetCategories();
        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_category = listBoxCategories.SelectedItem.ToString();
            //PerformanceCounterCategory tmp_Category = PerformanceCounterCategory.GetCategories().FirstOrDefault(cat => cat.CategoryName == selected_category);

            PerformanceCounterCategory[] categoryMatches = PerformanceCounterCategory.GetCategories();
            instanceListBox.Items.Clear();
            countersListBox.Items.Clear();

            foreach (PerformanceCounterCategory category in categoryMatches)
            {
                if (category.CategoryName == selected_category)
                {
                    string[] instance_names = category.GetInstanceNames();

                    foreach (string instance_name in instance_names)
                    {
                        instanceListBox.Items.Add(instance_name);
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void instanceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedIndex >= 0)
            {
                string selected_category = listBoxCategories.SelectedItem.ToString();
                string instance_name = instanceListBox.SelectedItem.ToString();

                PerformanceCounterCategory[] categoryMatches = PerformanceCounterCategory.GetCategories();
                foreach (PerformanceCounterCategory category in categoryMatches)
                {
                    if (category.CategoryName == selected_category)
                    {
                        PerformanceCounter[] counters = category.GetCounters(instance_name);
                        foreach (PerformanceCounter counter in counters)
                        {
                            countersListBox.Items.Add(counter.CounterName);
                            savedCounters = counters;
                        }
                    }
                }
            }
        }

        private void countersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countersListBox.SelectedIndex >= 0)
            {
                string counter_name = countersListBox.SelectedItem.ToString();
                foreach (PerformanceCounter counter in savedCounters)
                {
                    if (counter.CounterName == counter_name)
                    {
                        activeCounter = counter;
                        counterTextBox.Text = counter_name;
                    }
                }
            }
        }

        private void highthreshold_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            getAvailablePorts();
        }

        private void readsyslogButton_Click(object sender, EventArgs e)
        {
            read_system_log();
        }

        private void ArduinoAlert_Load(object sender, EventArgs e)
        {

        }
        /*
private void updateButton_Click(object sender, EventArgs e)
{
// Stop Thread
arduino_state = (int)ArdunioComState.Idling;
portStatusText.Text = "Idling";
System.Threading.Thread.Sleep(2000);

// Change variable now that it is safe to do so
global_highthreshold = highthreshold_TextBox.Text.ToString();
System.Threading.Thread.Sleep(1000);

arduino_state = (int)ArdunioComState.Running;
portStatusText.Text = "Running";
new Thread(() =>
{
Thread.CurrentThread.IsBackground = true;
SendCounter();
}).Start();


System.Threading.Thread.Sleep(1000);
}
*/
    } // close class ArduinoAlert
} // close namespace
