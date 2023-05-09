using System;
using System.Collections.Generic;
using algoritmo_login.User;
using algoritmo_login.Menu;

namespace algoritmo_login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuUser menu = new MenuUser();
            menu.MenuUsuario();
        }
    }
}