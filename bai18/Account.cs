using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai18
{
    public class Account
    {
        int id;
        string username;
        string password;

        public Account(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public Account()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}