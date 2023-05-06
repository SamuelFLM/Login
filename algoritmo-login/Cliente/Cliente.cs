using System;
using System.Collections.Generic;
using System.Text;

namespace algoritmo_login.User
{
    public class Cliente
    {
        private string Nome { get; set; }
        private byte Idade { get; set; }

        public Cliente(string nome, byte idade)
        {
            Nome = nome;
            Idade = idade;
;       }

    }
}
