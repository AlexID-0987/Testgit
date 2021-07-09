using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Socet_my
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip ="127.0.0.1";
            int port = 22123;
            IPEndPoint ad = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(ad);
            server.Listen(10);
            Console.WriteLine("hello server!");

            while(true)
            {
                Socket client = server.Accept();
                Console.WriteLine(client.RemoteEndPoint.ToString());

                Task.Run(() =>
                {
                    string mess = "You have to live";
                    byte[] by = Encoding.Default.GetBytes(mess);
                    for (int i = 0; i < 20; i++)
                    {
                        client.Send(by);
                        Thread.Sleep(1000);
                    }
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                });
                    
                
            }
        }
    }
}
