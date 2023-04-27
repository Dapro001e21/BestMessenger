using Models.Helpers;
using Models.Models;
using Models.ModelShells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BestMessenger.Network
{
    public class Server
    {
        private TcpClient client;
        public PacketReader PacketReader { get; private set; }
        public event Action<UserShellForServer> ConnectedEvent;
        public event Action MessageReceiveEvent;
        public Action DisconnectedEvent;

        public Server()
        {
            client = new TcpClient();
        }

        public void ConnectedToServer(UserShellForServer user)
        {
            if(!client.Connected)
            {
                client.Connect("127.0.0.1", 5000);
                PacketReader = new PacketReader(client.GetStream());
                var packet = new PacketBuilder();
                packet.SendUser(user);
                client.Client.Send(packet.GetPacket());
                ReadInputPackets();
            }    
        }

        private void ReadInputPackets()
        {
            Task.Run(() =>
            {
                while(true)
                {
                    var operation = PacketReader.ReadByte();
                    switch(operation)
                    {
                        case 0:
                            UserShellForServer user = PacketReader.ReciveUser();
                            ConnectedEvent?.Invoke(user);
                            break;
                        case 1:
                            MessageReceiveEvent?.Invoke();
                            break;
                        case 2:
                            DisconnectedEvent?.Invoke();
                            break;
                        default:
                            break;
                    }
                }
            });
        }

        public void SendMessageToServer(Message message)
        {
            var packet = new PacketBuilder();
            packet.WriteOperation(1);
            packet.SendMessage(message);
            client.Client.Send(packet.GetPacket());
        }
    }
}
