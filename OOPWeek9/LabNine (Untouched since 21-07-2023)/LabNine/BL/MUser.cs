﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.BL
{
    internal class MUser
    {
        private string userName;
        private string userPassword;
        private string userRole;

        public MUser(string userName, string userPassword, string userRole)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }
        public MUser(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = "NA";
        }

        public string getUserName()
        { return userName; }
        public string getUserPassword() { return userPassword; }
        public string getUserRole()
        {
            return userRole;
        }

        public bool isAdmin()
        {
            if(userRole == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}
