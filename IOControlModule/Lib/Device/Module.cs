using LedInterfaceLib;
using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ControlModule.Lib
{
    public class Module: ILed
    {
        public SolidColorBrush ledON { get; set; } //yellow
        public SolidColorBrush ledOFF { get; set; } //grey
        public SolidColorBrush ledError { get; set; } //red, optional use for error

        public Ellipse led { get; set; }
        public TextBox inTxt { get; set; }
        public Button btn { get; set; }
        public int n { get; set; }

        public string Name { get; set; }
        public bool State { get; set; }

        public Module(string Name , Ellipse led, TextBox inTxt, Button btn)
        {
                ledON = new SolidColorBrush();
                ledON.Color = Color.FromArgb(255, 255, 255, 0);  //ON Yellow
                ledOFF = new SolidColorBrush();
                ledOFF.Color = Color.FromArgb(100, 171, 153, 153);  //OFF No Color
                ledError = new SolidColorBrush();
                ledError.Color = Color.FromArgb(100, 144, 137, 29); //Error Red 

                this.Name = this.Name;
                this.led = led;
                this.inTxt = inTxt;
                this.btn = btn;
        }
          
        public int Condition()
        {
            int n = 0;
            if (State == true)
            {
                n = 1;
            }
            else
            {
                n = 0;
            }
            return n;
        }

        public int Control(int x)
        {
            if (x == 1)
            {
                State = true;
            }
            else
            {
                State = false;
            }
            return x;
        }

        public void ON()
        {
            State = true;
            switchLed(1);
        }

        public void OFF()
        {
            State = false;
            switchLed(0);
        }

        public int switchLed(int x)
        {
             
            led.Dispatcher.Invoke(new Action(() =>
             {
                 if (led.IsEnabled == true && x == 1)
                 {
                     led.Fill = ledON;
                     inTxt.Text = "ON";
                     n = 1;
                 }
                 else if (led.IsEnabled == true && x == 0)
                 {
                     led.Fill = ledOFF;
                     inTxt.Text = "OFF";
                     n = 0;
                 }
             }));
             return n;
         } 

        public int getLedState()
        {
             led.Dispatcher.Invoke(new Action(() =>
             {
                  if (led.IsEnabled == true && inTxt.Text == "1")
                  {
                      n = 1;
                  }
                  else if (led.IsEnabled == true && inTxt.Text == "0")
                  {
                      n = 0;
                  }
             }));
             return n;
        }
    }
}
