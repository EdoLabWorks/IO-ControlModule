using DataSource.Lib;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ControlModule.Lib
{
    // Tcp client for web interface socket I/O server
    class ModuleTcpClient
    {
        public static async Task RunClientAsync(string data)
        {
            await Task.Run(() =>
            {
                try
                {
                    ClientProcess(data);
                }
                catch (Exception e)
                {
                    Data.Source.Msg("\nModuleTcpClient connection error: " + e.Message);
                    Data.Source.Msg("\nCheck Socket I/O TcpServer status. Check web interface status.");
                }
            });
        }

        private static void ClientProcess(string data)
        {
            int serverPort = 5555;
            using (TcpClient client = new TcpClient("localhost", serverPort))
            using (NetworkStream networkstream  = client.GetStream())
            {
                Data.Source.Msg("\nModuleTcpClient connected to Socket IO TcpServer, msg: " + data); // for debug
                networkstream.WriteAsync(Encoding.UTF8.GetBytes(data), 0, Encoding.UTF8.GetBytes(data).Length);
                TxLedStatus();
            }
        }

        private async static void TxLedStatus()
        {
            await BlinkLed.Blink4(8);
        }
    }
}
