using ISwitchInterface.Lib;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LedInterfaceLib
{
    public interface ILed:ISwitch
    {
        SolidColorBrush ledON { get; set; }
        SolidColorBrush ledOFF { get; set; }
        SolidColorBrush ledError { get; set; }
        Ellipse led { get; set; } 
        TextBox inTxt { get; set; }
        Button btn { get; set; }
        int n { get; set; }
        int switchLed(int x);
        int getLedState();
    }
}
