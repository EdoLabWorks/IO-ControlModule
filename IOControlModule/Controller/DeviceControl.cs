using DataSource.Lib;
using ControlModule.Model;
using ISwitchInterface.Lib;
using System;

namespace ControlModule.Lib
{
    class DeviceControl
    {
        public static ISwitch[] Device;

        public static void DeviceOperation(string data)
        {
            int x = 0;
            switch (data)
            {

                /*************** 
                -o- Device 1 -o- 
                ****************/
                case "ON1":
                x = 1;
                Device[x].ON();
                DeviceEvent.ON1Event(); 
                break;

                case "OFF1": x = 1;
                Device[x].OFF();
                DeviceEvent.OFF1Event();
                break;

                /***************
                -o- Device 2 -o-
                ****************/
                case "ON2":
                x = 2;
                Device[x].ON();
                DeviceEvent.ON2Event();
                break;

                case "OFF2":
                x = 2;
                Device[x].OFF();
                DeviceEvent.OFF2Event();
                break;

                /***************
                -o- Device 3 -o-
                ****************/
                case "ON3":
                x = 3;
                Device[x].ON();
                DeviceEvent.ON3Event();
                break;
                
                case "OFF3":
                x = 3;
                Device[x].OFF();
                DeviceEvent.OFF3Event();
                break;

                /***************
                -o- Device 4 -o-
                ****************/
                case "ON4":
                x = 4;
                Device[x].ON();
                DeviceEvent.ON4Event();
                break;

                case "OFF4":
                x = 4;
                Device[x].OFF();
                DeviceEvent.OFF4Event();
                break;

                /***************
                -o- Device 5 -o-
                ****************/
                case "ON5":
                x = 5;
                Device[x].ON();
                DeviceEvent.ON5Event();
                break;

                case "OFF5":
                x = 5;
                Device[x].OFF();
                DeviceEvent.OFF5Event();
                break;

                /***************
                -o- Device 6 -o-
                ****************/
                case "ON6":
                x = 6;
                Device[x].ON();
                DeviceEvent.ON6Event();
                break;

                case "OFF6":
                x = 6;
                Device[x].OFF();
                DeviceEvent.OFF6Event();
                break;

                /********************
                -o- Control LED ON -o-
                *********************/
                case "ON7":
                x = 7;
                Device[x].ON();
                break;
                /********************
                -o- Control LED OFF -o-
                *********************/
                case "OFF7":
                x = 7;
                Device[x].OFF();
                break;

                default:
                throw new ArgumentException("unexpected control code type");
            }
        }
    }
}
