﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateOfSend { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}
