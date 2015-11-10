using ISwitchInterface.Lib;
using System.Threading;
using System.Threading.Tasks;

namespace ControlModule.Lib
{
    //you can create your own Led on/off pattern or use the pattern below
    class BlinkLed
    {
        public static ISwitch[] Device;
        //pattern1
        public static async Task Blink1()
        {
            int timer = 40;
            for (int i = 9; i >= 1 ; i--)
            {
                await Task.Delay(timer);
                Device[i].OFF();
            }
            for (int i = 1; i < 4; i++)
            {
                Device[7].OFF();
                await Task.Delay(timer);
                Device[7].ON();
              
                await Task.Delay(timer);
            }
            await Blink4(9);
            await Blink4(8);
        }
        //pattern2
        public static async Task Blink2()
        {
            //remember there is no Led0 or LedArray[0]!!!
            int timer = 50;
            for (int i = 1; i < 10; i++)
            {
                await Task.Delay(timer);
                Device[i].ON();
            }
        }
        //pattern3
        public static async Task Blink3(int n)
        {
            int timer = 35;
            for (int i = 1; i < 3; i++)
            {

                Device[n].ON(); 
                await Task.Delay(timer);
                Device[n].OFF();
            }
        }
        //pattern4
        public static async Task Blink4(int n)
        {
            int timer = 35;
            for (int i = 1; i < 3; i++)
            {
                Device[n].OFF();
                await Task.Delay(timer);
                Device[n].ON();
                await Task.Delay(timer);
                Device[n].OFF();
            }
        }
        //pattern5
        public static void blink5()
        {
            Device[1].ON();
            Thread.Sleep(100);
            Device[2].ON();
            Thread.Sleep(100);
            Device[3].ON();
            Thread.Sleep(100);
            Device[4].ON();
            Thread.Sleep(100);
            Device[5].ON();
            Thread.Sleep(100);
            Device[6].ON();
            Thread.Sleep(100);
            Device[1].OFF();
            Thread.Sleep(100);
            Device[2].OFF();
            Thread.Sleep(100);
            Device[3].OFF();
            Thread.Sleep(100);
            Device[4].OFF();
            Thread.Sleep(100);
            Device[5].OFF();
            Thread.Sleep(100);
            Device[6].OFF();
        }
        
    }
}