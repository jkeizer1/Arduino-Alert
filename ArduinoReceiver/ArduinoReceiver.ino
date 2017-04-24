//LCD1602
//You should now see your LCD1602 display the flowing characters "SUNFOUNDER" and "hello, world"
//Email:support@sunfounder.com
//Website:www.sunfounder.com
//2015.5.7 
#include <LiquidCrystal.h>// include the library code
/**********************************************************/
char nodata[]=  "No Data.........";  //the string to print on the LCD when no data is ready

String comdata = "";       // floating point number received from computer
String comline = "";       // message title
String highthreshold = ""; // threshold to compare wtih
int lastLength = 0;

const int greenPin = 9;
const int whitePin = 8;
const int redPin = 7;

char floatbuf[32];
char floatbuf2[32];

int tim = 250;  //the value of delay time
// initialize the library with the numbers of the interface pins
LiquidCrystal lcd(4, 6, 10, 11, 12, 13);
/*********************************************************/
void setup()
{
  pinMode(greenPin,OUTPUT);//initialize the digital pin as an output
  pinMode(whitePin,OUTPUT);//initialize the digital pin as an output
  pinMode(redPin,OUTPUT);//initialize the digital pin as an output
  Serial.setTimeout(100);
  
  lcd.begin(16, 2);  // set up the LCD's number of columns and rows: 
  Serial.begin(38400);  // start serial port at 9600 bps:
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }
  Serial.println("READY");
}
/*********************************************************/
void loop() 
{

    //read string from serial monitor
    if(Serial.available()>0)  // if we get a valid byte, read digital ins:
    {  
       comdata = "";
       comline = "";
       while (Serial.available() > 0)  
       {        
          //comdata += char(Serial.read());
          comline = Serial.readStringUntil('!');

          if (Serial.available() > 0) {
              highthreshold = Serial.parseFloat();
          }

          if (Serial.available() > 0) {
            comdata = Serial.parseFloat();
            //delay(20);
          }
       }
       Serial.println("READY");
    }
    else {
      comline = "No Counter ";
      comdata = "No Data";
      highthreshold = 1.0;
    }
    
    lcd.clear();  //Clears the LCD screen and positions the cursor in the upper-left corner.
    //lcd.setCursor(0,1);
    lcd.print(comline);
    

    highthreshold.toCharArray(floatbuf2, sizeof(floatbuf2));
    float highthresholdvalue = atof(floatbuf2);

    if (highthresholdvalue >= 1000.0) {
        float scaledvalue = highthresholdvalue/1000.0;
        char buf[32];
        dtostrf(scaledvalue,3,1,buf);   
        lcd.setCursor(0,2);
        lcd.print("[");
        lcd.print(buf);
        lcd.print("K]: ");
    }
    else {
        lcd.setCursor(0,2);
        lcd.print("[");
        lcd.print(highthreshold);
        lcd.print("]: ");
    }
    
    digitalWrite(redPin, LOW);
    delay(5);
   
    int position = 0;
    int offset = 0;

    
    if (comdata.length() > 0) {
        digitalWrite(whitePin, LOW);
        digitalWrite(greenPin, HIGH);
  
        comdata.toCharArray(floatbuf, sizeof(floatbuf));
        float value = atof(floatbuf);
        
        if (value > highthresholdvalue) {
          digitalWrite(redPin, HIGH);
        }
        else digitalWrite(redPin, LOW);

        position = 0;
        offset = 0;

        if (value >= 1000.0) {
           float scaledvalue = value/1000.0;
           char buf[32];
           dtostrf(scaledvalue,3,1,buf);   
           lcd.print(buf);
           lcd.print("K");
        }
        else {
           lcd.print(comdata);
        }
        /*      
        for ( position = 0; position < comdata.length(); position++)
        {
          //lcd.setCursor(offset + position,2);
          lcd.setCursor(position,2);
          lcd.print(comdata[position]);  // Print a message to the LCD.
          offset = offset+1;
          //lcd.scrollDisplayLeft();  //Scrolls the contents of the display one space to the left.
          //delay(10);    
        } 
        */   
      
        delay(700);
        digitalWrite(greenPin, LOW);
        digitalWrite(redPin, LOW);
        //delay(500);
    }
    
    else {
        // No Data Message
        int position = 0;
        for ( position = 0; position < 16; position++)
        {
          lcd.setCursor(position,2);
          lcd.print(nodata[position]);  // Print a message to the LCD.
          digitalWrite(whitePin, HIGH);
          digitalWrite(greenPin, LOW);

          delay(10);  //wait for 250 microseconds
        }
        delay(1000);
    }
              
 

}
/************************************************************/
