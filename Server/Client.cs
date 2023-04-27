
using Models.Models;
using Models.ModelShells;
using Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Client
    {
        public TcpClient ClientSocket { get; set; }
        public UserShellForServer User;
        private PacketReader _packetReader;

        public Client(TcpClient client)
        {
            ClientSocket = client;
            _packetReader = new PacketReader(ClientSocket.GetStream());
            User = _packetReader.ReciveUser();
            Console.WriteLine($"Пользователь {User.Id} {User.FirstName} {User.LastName} присоединился {DateTime.Now.ToShortDateString()}");
            Task.Run(() => {
                Listen();
            });
        }

        private void Listen()
        {
            while(true)
            {
                try
                {
                    var operation = _packetReader.ReadByte();
                    switch (operation)
                    {
                        case 0:
                            //Program.BroadcastConnection();
                            break;
                        case 1:
                            var message = _packetReader.ReciveMessage();
                            Console.WriteLine($"{User.FirstName} {User.LastName} {message.DateOfSend}: {message.Text}");
                            Program.BroadcastMessage(message);
                            break;
                        case 2:
                            break;
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
