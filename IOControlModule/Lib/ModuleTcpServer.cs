using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Text;
using DataSource.Lib;

namespace ControlModule.Lib
{
    // Tcp server for web interface control code
    class ModuleTcpServer
    {
        static bool done { get; set; }
        public static async Task RunServerAsync()
        {
            int port = 51111;
            TcpListener listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            Data.Source.Msg("ModuleTcpServer waiting for connection on port " + port);
            while (!done)
            {
                    try
                    {
                        await ServerProcess(listener);
                    }
                    catch (Exception ex)
                    {
                        done = true;
                        Data.Source.Msg("\nModuleTcpServer error:" + ex.Message + "\nServer is stopped!");
                }
            }
            listener.Stop();
            done = false;
            Data.Source.Msg("\nPls. check server status and restart.");
        }

        private async static Task ServerProcess(TcpListener listener)
        {
            using (TcpClient c = await listener.AcceptTcpClientAsync())
            using (NetworkStream networkstream = c.GetStream())
            {
                //int ControlCode = int.Parse(Encoding.UTF8.GetString(await ReadMessage(networkstream)));
                string ControlCode = Encoding.UTF8.GetString(await ReadMessage(networkstream));
                RxLedStatus();
                DeviceControl.DeviceOperation(ControlCode);
                Data.Source.Msg("\nModuleTcpServer client control code: " + ControlCode);
            }
        }

        // read memory buffer helper
		async static Task<byte[]>ReadMessage(NetworkStream s)
		{
			MemoryStream ms = new System.IO.MemoryStream();
			byte[] buffer = new byte[0x1000];
			do { ms.Write(buffer, 0, await s.ReadAsync(buffer, 0, buffer.Length)); }
			while (s.DataAvailable);
			return ms.ToArray();
		}

        // receive data indicator  
        private async static void RxLedStatus()
        {
            await BlinkLed.Blink3(9);
        }
    }
}
