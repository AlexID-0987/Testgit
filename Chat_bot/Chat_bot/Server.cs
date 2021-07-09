using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chat_bot
{
    class Server
    {
        List<Socket> clients = new List<Socket>();
        string ip = "127.0.0.6";
        int port = 34;
        IPEndPoint ep;
        Socket server;
        public Server()
        {
            ep = new IPEndPoint(IPAddress.Parse(ip), port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(ep);
        }
        public void Drive()
        {
            server.Listen(5);
            Console.WriteLine("Server Start");
            

            while (true)
            {
                Socket cl = server.Accept();
                clients.Add(cl);
                Console.WriteLine(cl.RemoteEndPoint.ToString());
                string mess = "Good morring!Frends";
                byte[] b = Encoding.Default.GetBytes(mess);
                cl.Send(b);
                Task.Run(() =>
                {
                    byte[] byt = new byte[300];
                    cl.Receive(byt);
                    foreach(var cli in clients)
                    {
                        if (cli.RemoteEndPoint.ToString() != cl.RemoteEndPoint.ToString())
                        {
                            
                            
                                cli.Send(byt);
                            
                        }
                    }

                });
                
                        
                    
            }
            
        }
        
    }
}
