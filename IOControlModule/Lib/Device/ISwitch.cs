namespace ISwitchInterface.Lib
{
    public interface ISwitch
    {
        string Name { get; set; }
        bool State { get; set; }
        int Condition();
        int Control(int x);
        void ON();
        void OFF();
    }
}
