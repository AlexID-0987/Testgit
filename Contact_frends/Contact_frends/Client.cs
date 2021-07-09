using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Contact_frends
{
    class Client
    {
        string ip = "127.0.0.3";
        int port = 22;
        IPEndPoint ep;
        Socket client;
        public Client()
        {
            ep = new IPEndPoint(IPAddress.Parse(ip), port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

        }
        public string ConnectChat()
        {
            client.Connect(ep);
            byte[] byt = new byte[100];
            client.Receive(byt);
            return Encoding.Default.GetString(byt);
        }
        public void Messge(string mess1)
        {
            byte[] b = Encoding.Default.GetBytes(mess1);
            client.Send(b);
        }
        public string ReciveMes()
        {
                byte[] byt = new byte[300];
                client.Receive(byt);
                return Encoding.Default.GetString(byt);
           
        }
    }
}
