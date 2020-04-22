using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Application.InputModels.Login
{
    public class LoginInput
    {
        public LoginInput(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
