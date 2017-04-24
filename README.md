# Arduino-Alert
Monitor user selected computer alerts based on thresholds using your Arduino (LED lights, LCD Display).
See jknotes.com (Arduino Blog) for more information.
There are two components in this project.  
#1 Arduino .ino program - receives data from the computer over USB, displays information on a 1602 LCD, and lights LEDs to indicate passed thresholds.
#2 C# program: This is a windows forms program that allows the user to browse and select windows categories and counters, and set threshold limits for the arduino to report.
