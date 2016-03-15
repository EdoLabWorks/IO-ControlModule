using System;
using System.Windows;
using System.Windows.Controls;

// using a simple event based messaging for WPF application 
namespace DataSource.Lib
{
    public class DataInfoEventArgs : EventArgs
    {
        public DataInfoEventArgs(string data)
        {
            this.Data = data;
        }
        public string Data { get; private set; }
    }
    //using events instead of databinding for mainwindow debug panel textbox display
    public class Data
    {
        public static bool initFlag { get; set; }
        
        //send a warning if event is not registered
        public static Data Source = new Data(); 

        public event EventHandler<DataInfoEventArgs> NewInfo;

        public static void eventAlert()
        {
            MessageBox.Show("Warning!  Event not registered.\nSource could be null.");
        }

        public void Msg(string data)
        {
            
            if (initFlag == false)
                eventAlert();
            if (Source != null)
                RaiseNewInfo(data);
        }

        protected virtual void RaiseNewInfo(string data)
        {
            EventHandler<DataInfoEventArgs> newInfo = NewInfo;
            if (newInfo != null)
            {
                newInfo(this, new DataInfoEventArgs(data));
            }
        }
    }
    //for event subscriber
    public class EventUser
    {
        private TextBox textbox;

        public EventUser(TextBox textbox)
        {
            this.textbox = textbox;
            //initialize source event and register a ready to use handler
            initEvent(); 
        }

        private void initEvent()
        {
            if (Data.Source == null)
            {
                Data.Source = new Data();
                Data.initFlag = true;
            }
            else
            {
                Data.Source = new Data();
                Data.initFlag = true;
            }
            Data.Source.NewInfo += NewDataHandler;
        }
        //async thread safe
        private async void NewDataHandler(object sender, DataInfoEventArgs e)
        {
            await textbox.Dispatcher.InvokeAsync(new Action(() =>
            {
                textbox.AppendText(e.Data);
            }));
        }

        public void removeDataHandler()
        {
                Data.Source.NewInfo -= NewDataHandler;
        }
    }
}
