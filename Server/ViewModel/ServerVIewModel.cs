using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.ViewModel
{
   public class ServerVIewModel:BaseViewModel
    {
        public ServerVIewModel()
        {
            IPEndPoint endp = new IPEndPoint(IPAddress.Parse("10.1.16.13"), 1031);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(endp);
            socket.Listen(10);



        Task receiver = Task.Run(() =>
        {
            while (true)
            {
                int length = client.Receive(buffer);
                Console.WriteLine("Client  " + Encoding.ASCII.GetString(buffer, 0, length));
            }

        });

        }
    }
}
