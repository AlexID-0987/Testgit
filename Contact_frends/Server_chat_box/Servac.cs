using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_chat_box
{
    class Servac
    {
        List<Socket> frends = new List<Socket>();
        string ip = "127.0.0.3";
        int port = 22;
        IPEndPoint ep;
        Socket server;
        public Servac()
        {
            ep = new IPEndPoint(IPAddress.Parse(ip), port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(ep);
        }
        public void drave()
        {
            server.Listen(10);
            Console.WriteLine("Yoo in servac");
            
            
            while (true)
            {
                Socket client = server.Accept();
                Console.WriteLine(client.RemoteEndPoint.ToString());
                frends.Add(client);
                string mess = "You in chat";
                byte[] b = Encoding.Default.GetBytes(mess);
                client.Send(b);
                Task.Run(() =>
                {
                    while (true)
                    {
                        byte[] byt = new byte[300];
                        client.Receive(byt);
                        foreach (var cli in frends)
                        {
                            if(cli.RemoteEndPoint.ToString()!=client.RemoteEndPoint.ToString())
                            {
                                cli.Send(byt);
                            }
                        }
                    }
                });
            }
        }
    }
}
