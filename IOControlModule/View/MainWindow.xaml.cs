using ControlModule.Lib;
using DataSource.Lib;
using ISwitchInterface.Lib;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ControlModule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            int[] i = new int[25];
            EventUser msg = null;
            public static ISwitch[] Device = new Module[25];

            public MainWindow()
            {
                InitializeComponent();
            }
          
            //autoscroll for debug display output 
            private void display_TextChanged_1(object sender, TextChangedEventArgs e)
            { 
               display.ScrollToEnd();
            }

            private void Window_Loaded(object sender, RoutedEventArgs e)
            {
                initProcess();
            }

            private async void initProcess()
            {
               //register msg event for debug panel display output 
               msg = new EventUser(display);

               display.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
               display.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
               display.IsReadOnly = true;
               //device LED indicator, controllable
               Device[0] = new Module("Device 0", led1, inTxt1, btn1);          //not used 
               Device[1] = new Module("Device 1", led1, inTxt1, btn1);
               Device[2] = new Module("Device 2", led2, inTxt2, btn2);
               Device[3] = new Module("Device 3", led3, inTxt3, btn3);
               Device[4] = new Module("Device 4", led4, inTxt4, btn4);
               Device[5] = new Module("Device 5", led5, inTxt5, btn5);
               Device[6] = new Module("Device 6", led6, inTxt6, btn6);
               //panel LED indicators
               Device[7] = new Module("ServerLed", ledServer, inTxt7, btn1);   //btn1 used as dummy variable
               Device[8] = new Module("TxLed", Txled, inTxt8, btn1);           //btn1 used as dummy variable
               Device[9] = new Module("Rxled", Rxled, inTxt9, btn1);           //btn1 used as dummy variable

               ControlModule.Lib.DeviceControl.Device = Device;
               ControlModule.Lib.BlinkLed.Device = Device;

               serverButton.IsEnabled = false;

               try
               {
                    await BlinkLed.Blink2();
                    await BlinkLed.Blink1();
                    await ControlModule.Lib.ModuleTcpServer.RunServerAsync();
                }
                catch (Exception ex)
               {
                    statBar.Content = "Not Ready. There seems to be an error during startup.";
                    MessageBox.Show(ex.Message, "ERROR!!!");
               }
            }
            
            // disabled for now
            private void serverButton_Click(object sender, RoutedEventArgs e)
            {
                //serverButton.IsEnabled = false;
                //await ControlModule.Lib.ModuleTcpServer.RunServerAsync();
            }
            // disabled for now
            private void clientButton_Click(object sender, RoutedEventArgs e)
            {
                //serverButton.IsEnabled = true;
                //await ModuleTcpClient.RunClientAsync("ON1");
            }

            private async void btn1_Click(object sender, RoutedEventArgs e)
            {
                if (Device[1].State == false) { Device[1].ON(); 
                await ModuleTcpClient.RunClientAsync("Device1 ON");
                }
                else { Device[1].OFF();
                await ModuleTcpClient.RunClientAsync("Device1 OFF");
                }
            }   
         
            private async void btn2_Click(object sender, RoutedEventArgs e)
            {
                if (Device[2].State == false) { Device[2].ON();
                await ModuleTcpClient.RunClientAsync("Device2 ON");
                }
                else { Device[2].OFF();
                await ModuleTcpClient.RunClientAsync("Device2 OFF");
                }
            }

            private async void btn3_Click(object sender, RoutedEventArgs e)
            {
                if (Device[3].State == false) { Device[3].ON();
                await ModuleTcpClient.RunClientAsync("Device3 ON");
                }
                else { Device[3].OFF();
                await ModuleTcpClient.RunClientAsync("Device3 OFF");
                }
            }

            private async void btn4_Click(object sender, RoutedEventArgs e)
            {
                if (Device[4].State == false) { Device[4].ON();
                await ModuleTcpClient.RunClientAsync("Device4 ON");
                }
                else { Device[4].OFF();
                await ModuleTcpClient.RunClientAsync("Device4 OFF");
                }
            }

            private async void btn5_Click(object sender, RoutedEventArgs e)
            {
                if (Device[5].State == false) { Device[5].ON();
                await ModuleTcpClient.RunClientAsync("Device5 ON");
                }
                else { Device[5].OFF();
                await ModuleTcpClient.RunClientAsync("Device5 OFF");
                }
            }

            private async void btn6_Click(object sender, RoutedEventArgs e)
            {
                if (Device[6].State == false) { Device[6].ON();
                await ModuleTcpClient.RunClientAsync("Device6 ON");
                }
                else { Device[6].OFF();
                await ModuleTcpClient.RunClientAsync("Device6 OFF");
                }
            }

            private void Settings_Menu_Click(object sender, RoutedEventArgs e)
            {
                Exit();
            }

            private  void Window_Unloaded(object sender, RoutedEventArgs e)
            {
                Exit();
            }

            void Exit()
            {
                // remove event msg as listener
                msg.removeDataHandler();
                Application.Current.Shutdown();
            }

            private void Help_Menu_Click(object sender, RoutedEventArgs e)
            {
            HelpAboutWindow about = new HelpAboutWindow("About IOControlModule App", "A simple framework for digital I/O control." +
                                      "\n\n-Ed Alegrid");
            }
    }      
}
