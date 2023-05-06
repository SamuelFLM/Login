using System;
using System.Collections.Generic;
using System.Text;
using algoritmo_login.User;

namespace algoritmo_login.Login
{
    public class Login
    {
        private Register register { get; set; }
        private Cliente cliente { get; set; }
        public Login(Register register, Cliente cliente)
        {
            this.register = register;
            this.cliente = cliente;
        }
    }
}
