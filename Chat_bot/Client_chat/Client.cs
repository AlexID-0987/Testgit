using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client_chat
{
    class Client
    {
        string ip = "127.0.0.6";
        int port = 34;
        IPEndPoint ep;
        Socket client;
        public Client()
        {
            ep = new IPEndPoint(IPAddress.Parse(ip), port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        }
        public string Connect_chat()
        {
            client.Connect(ep);
            byte[] by = new byte[100];
            client.Receive(by);
            return Encoding.Default.GetString(by);
        }
        public void Mess(string msg)
        {
            byte[] by = Encoding.Default.GetBytes(msg);
            client.Send(by);
        }
         public string Remess()
        {
            byte[] b = new byte[300];
            client.Receive(b);
            return Encoding.Default.GetString(b);
        }
    }
}
