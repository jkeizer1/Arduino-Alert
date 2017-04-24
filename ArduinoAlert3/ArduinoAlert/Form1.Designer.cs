namespace ArduinoAlert
{
    partial class ArduinoAlert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArduinoAlert));
            this.COMPortList = new System.Windows.Forms.ComboBox();
            this.ArduinoComLinkGroupBox = new System.Windows.Forms.GroupBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portStatusText = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.instanceListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countersListBox = new System.Windows.Forms.ListBox();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PressStopLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.highthreshold_TextBox = new System.Windows.Forms.TextBox();
            this.counterTextBox = new System.Windows.Forms.TextBox();
            this.SystemLogGroupBox = new System.Windows.Forms.GroupBox();
            this.syslogListBox = new System.Windows.Forms.ListBox();
            this.readsyslogButton = new System.Windows.Forms.Button();
            this.ArduinoComLinkGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SystemLogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMPortList
            // 
            this.COMPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPortList.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPortList.ForeColor = System.Drawing.Color.RoyalBlue;
            this.COMPortList.FormattingEnabled = true;
            this.COMPortList.Location = new System.Drawing.Point(19, 51);
            this.COMPortList.Name = "COMPortList";
            this.COMPortList.Size = new System.Drawing.Size(91, 23);
            this.COMPortList.TabIndex = 1;
            this.COMPortList.SelectedIndexChanged += new System.EventHandler(this.COMPortList_SelectedIndexChanged);
            // 
            // ArduinoComLinkGroupBox
            // 
            this.ArduinoComLinkGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ArduinoComLinkGroupBox.Controls.Add(this.connectButton);
            this.ArduinoComLinkGroupBox.Controls.Add(this.label1);
            this.ArduinoComLinkGroupBox.Controls.Add(this.portStatusText);
            this.ArduinoComLinkGroupBox.Controls.Add(this.stopButton);
            this.ArduinoComLinkGroupBox.Controls.Add(this.startButton);
            this.ArduinoComLinkGroupBox.Controls.Add(this.COMPortList);
            this.ArduinoComLinkGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArduinoComLinkGroupBox.ForeColor = System.Drawing.Color.Orange;
            this.ArduinoComLinkGroupBox.Location = new System.Drawing.Point(12, 15);
            this.ArduinoComLinkGroupBox.Name = "ArduinoComLinkGroupBox";
            this.ArduinoComLinkGroupBox.Size = new System.Drawing.Size(385, 129);
            this.ArduinoComLinkGroupBox.TabIndex = 3;
            this.ArduinoComLinkGroupBox.TabStop = false;
            this.ArduinoComLinkGroupBox.Text = "Arduino Serial Setup";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(20, 83);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(91, 31);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Load";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = " Port     ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // portStatusText
            // 
            this.portStatusText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.portStatusText.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portStatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.portStatusText.Location = new System.Drawing.Point(121, 89);
            this.portStatusText.Name = "portStatusText";
            this.portStatusText.ReadOnly = true;
            this.portStatusText.Size = new System.Drawing.Size(252, 22);
            this.portStatusText.TabIndex = 4;
            this.portStatusText.Text = "No Arduino Serial Port Detected";
            this.portStatusText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.portStatusText.Visible = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Gainsboro;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.stopButton.Location = new System.Drawing.Point(250, 27);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(123, 56);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Gainsboro;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.startButton.Location = new System.Drawing.Point(120, 27);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(123, 56);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.instanceListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.countersListBox);
            this.groupBox1.Controls.Add(this.listBoxCategories);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 520);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Performance Variables";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instances in Categories";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // instanceListBox
            // 
            this.instanceListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.instanceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instanceListBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instanceListBox.FormattingEnabled = true;
            this.instanceListBox.ItemHeight = 16;
            this.instanceListBox.Location = new System.Drawing.Point(369, 65);
            this.instanceListBox.Name = "instanceListBox";
            this.instanceListBox.Size = new System.Drawing.Size(303, 436);
            this.instanceListBox.TabIndex = 4;
            this.instanceListBox.SelectedIndexChanged += new System.EventHandler(this.instanceListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Counters In Instance";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categories";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // countersListBox
            // 
            this.countersListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.countersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countersListBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.countersListBox.FormattingEnabled = true;
            this.countersListBox.ItemHeight = 16;
            this.countersListBox.Location = new System.Drawing.Point(709, 65);
            this.countersListBox.Name = "countersListBox";
            this.countersListBox.Size = new System.Drawing.Size(320, 436);
            this.countersListBox.TabIndex = 1;
            this.countersListBox.SelectedIndexChanged += new System.EventHandler(this.countersListBox_SelectedIndexChanged);
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCategories.ForeColor = System.Drawing.Color.MidnightBlue;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 16;
            this.listBoxCategories.Location = new System.Drawing.Point(20, 65);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(320, 436);
            this.listBoxCategories.Sorted = true;
            this.listBoxCategories.TabIndex = 0;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.PressStopLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.highthreshold_TextBox);
            this.groupBox2.Controls.Add(this.counterTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Orange;
            this.groupBox2.Location = new System.Drawing.Point(440, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alarm Settings";
            // 
            // PressStopLabel
            // 
            this.PressStopLabel.AutoSize = true;
            this.PressStopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressStopLabel.ForeColor = System.Drawing.Color.Moccasin;
            this.PressStopLabel.Location = new System.Drawing.Point(266, 97);
            this.PressStopLabel.Name = "PressStopLabel";
            this.PressStopLabel.Size = new System.Drawing.Size(225, 18);
            this.PressStopLabel.TabIndex = 4;
            this.PressStopLabel.Text = "Press Stop To Change Value";
            this.PressStopLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Red Alarm Threshold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Selected Counter";
            // 
            // highthreshold_TextBox
            // 
            this.highthreshold_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highthreshold_TextBox.ForeColor = System.Drawing.Color.Black;
            this.highthreshold_TextBox.Location = new System.Drawing.Point(269, 68);
            this.highthreshold_TextBox.Name = "highthreshold_TextBox";
            this.highthreshold_TextBox.Size = new System.Drawing.Size(220, 24);
            this.highthreshold_TextBox.TabIndex = 1;
            this.highthreshold_TextBox.Text = "50.0";
            this.highthreshold_TextBox.TextChanged += new System.EventHandler(this.highthreshold_TextBox_TextChanged);
            // 
            // counterTextBox
            // 
            this.counterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterTextBox.ForeColor = System.Drawing.Color.Black;
            this.counterTextBox.Location = new System.Drawing.Point(19, 68);
            this.counterTextBox.Name = "counterTextBox";
            this.counterTextBox.ReadOnly = true;
            this.counterTextBox.Size = new System.Drawing.Size(208, 24);
            this.counterTextBox.TabIndex = 0;
            // 
            // SystemLogGroupBox
            // 
            this.SystemLogGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SystemLogGroupBox.Controls.Add(this.readsyslogButton);
            this.SystemLogGroupBox.Controls.Add(this.syslogListBox);
            this.SystemLogGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemLogGroupBox.ForeColor = System.Drawing.Color.Orange;
            this.SystemLogGroupBox.Location = new System.Drawing.Point(1081, 150);
            this.SystemLogGroupBox.Name = "SystemLogGroupBox";
            this.SystemLogGroupBox.Size = new System.Drawing.Size(419, 519);
            this.SystemLogGroupBox.TabIndex = 6;
            this.SystemLogGroupBox.TabStop = false;
            this.SystemLogGroupBox.Text = "System Log";
            // 
            // syslogListBox
            // 
            this.syslogListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.syslogListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syslogListBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.syslogListBox.FormattingEnabled = true;
            this.syslogListBox.ItemHeight = 16;
            this.syslogListBox.Location = new System.Drawing.Point(16, 71);
            this.syslogListBox.Name = "syslogListBox";
            this.syslogListBox.Size = new System.Drawing.Size(383, 436);
            this.syslogListBox.TabIndex = 0;
            // 
            // readsyslogButton
            // 
            this.readsyslogButton.Location = new System.Drawing.Point(18, 36);
            this.readsyslogButton.Name = "readsyslogButton";
            this.readsyslogButton.Size = new System.Drawing.Size(144, 29);
            this.readsyslogButton.TabIndex = 1;
            this.readsyslogButton.Text = "Read System Log";
            this.readsyslogButton.UseVisualStyleBackColor = true;
            this.readsyslogButton.Click += new System.EventHandler(this.readsyslogButton_Click);
            // 
            // ArduinoAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1524, 693);
            this.Controls.Add(this.SystemLogGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ArduinoComLinkGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArduinoAlert";
            this.Opacity = 0.95D;
            this.Text = "Keizer Arduino Alert";
            this.Load += new System.EventHandler(this.ArduinoAlert_Load);
            this.ArduinoComLinkGroupBox.ResumeLayout(false);
            this.ArduinoComLinkGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SystemLogGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox COMPortList;
        private System.Windows.Forms.GroupBox ArduinoComLinkGroupBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox portStatusText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox countersListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox instanceListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox highthreshold_TextBox;
        private System.Windows.Forms.TextBox counterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PressStopLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox SystemLogGroupBox;
        private System.Windows.Forms.Button readsyslogButton;
        private System.Windows.Forms.ListBox syslogListBox;
    }
}

