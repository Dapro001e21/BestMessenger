﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelShells
{
    [Serializable]
    public class UserShellForServer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoSource { get; set; } = "D:\\Projects\\Visual Studios Projects\\C#\\BestMessenger\\BestMessenger\\Infrastructure\\Images\\PhotoSource.jpg";
        public bool IsFriend { get; set; }
    }
}
