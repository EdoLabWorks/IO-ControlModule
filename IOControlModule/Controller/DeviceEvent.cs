using ControlModule.Lib;
using DataSource.Lib;
using System;

namespace ControlModule.Model
{
    class DeviceEvent
    {
        public async static void ON1Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("ON1");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void OFF1Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("OFF1");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void ON2Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("ON2");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void OFF2Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("OFF2");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void ON3Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("ON3");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void OFF3Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("OFF3");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void ON4Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("ON4");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void OFF4Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("OFF4");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void ON5Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("ON5");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void OFF5Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("OFF5");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void ON6Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("ON6");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }

        public async static void OFF6Event()
        {
            try
            {
                await ModuleTcpClient.RunClientAsync("OFF6");
            }
            catch (InvalidOperationException ex)
            {
                Data.Source.Msg("\nEvent Error: " + ex.Message);
            }
        }
    }
}
