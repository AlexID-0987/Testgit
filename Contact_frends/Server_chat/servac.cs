using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_chat
{
    class servac
    {
        List<Socket> frends = new List<Socket>();
        string ip = "137.0.0.3";
        int port = 22;
        IPEndPoint ep;
        Socket server;
        public servac()
        {
            ep = new IPEndPoint(IPAddress.Parse(ip), port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(ep);
        }
        public void drave()
        {
            server.Listen(10);
            while(true)
            {
                Socket client = server.Accept();
                string mess = "You in chat";
                byte[] b = Encoding.Default.GetBytes(mess);
                client.Send(b);
            }
        }
    }
}
