using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    internal class Account
    {
        string _id;
        string _username;
        string _password;
        string _created;

        public string Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Created { get => _created; set => _created = value; }

        public Account(string id, string username, string password, string created)
        {
            _id = id;
            _username = username;
            _password = password;
            this._created = created;
        }

        public Account()
        {

        }

        public override string ToString()
        {
            return _username;
        }
    }
}
