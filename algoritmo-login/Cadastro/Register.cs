using System;
using System.Collections.Generic;
using System.Text;

namespace algoritmo_login.User
{
    public class Register
    {
        private string Email { get; set; }
        private string Senha { get; set; }

        public Register(string email, string senha) { 
            this.Email = email;
            this.Senha = senha;
        }
    }
}
