﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09
{
    internal class user
    {
        public string username { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public user(string username, string name, string password)
        {
            this.username = username;
            this.name = name;
            this.password = password;
        }
    }
}
