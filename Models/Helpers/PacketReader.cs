﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Models.Models;
using Models.ModelShells;

namespace Models.Helpers
{
    public class PacketReader : BinaryReader
    {
        NetworkStream stream;
        BinaryFormatter binaryFormatter;
        public PacketReader(NetworkStream stream) : base(stream)
        {
            this.stream = stream;
            this.binaryFormatter = new BinaryFormatter();
        }

        public UserShellForServer ReciveUser()
        {
            var user = (UserShellForServer)binaryFormatter.Deserialize(stream);
            return user;
        }

        public Message ReciveMessage()
        {
            var message = (Message)binaryFormatter.Deserialize(stream);
            return message;
        }
    }
}
