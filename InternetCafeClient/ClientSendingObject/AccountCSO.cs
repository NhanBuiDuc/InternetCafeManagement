﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using InternetCafeClient.SocketConnection;
namespace InternetCafeClient.ClientSendingObject
{
    [Serializable]
    public class AccountCSO
    {
        private string username;
        private string password;
        private string action;
        private string status;
        public AccountCSO()
        {
        }
        public AccountCSO(string username, string password, string action, string status)
        {
            this.Username = username;
            this.Password = password;
            this.Action = action;
            this.Status = status;
        }
        
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Action { get => action; set => action = value; }
        public string Status { get => status; set => status = value; }

        public void login()
        {
            Client client = new Client();
            client.Connect();
            client.Send(this);
        }
    }
}
