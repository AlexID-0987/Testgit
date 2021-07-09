using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_client
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip ="127.0.0.1";
            int port =22123;
            IPEndPoint ad = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            client.Connect(ad);
            byte[] bytes= new byte[100];
            for(int i=0;i<30;i++)
            {
                client.Receive(bytes);
                Console.WriteLine(DateTime.UtcNow);
            }
            client.Close();
        }
    }
}
