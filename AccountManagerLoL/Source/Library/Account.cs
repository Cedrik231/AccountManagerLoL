using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagerLoL.Source.Library
{
    public class Account
    {
        string name;
        string username;
        string password;

        public Account(string name, string username, string password)
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }

        public Account()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
