﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Admin
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public Admin(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
