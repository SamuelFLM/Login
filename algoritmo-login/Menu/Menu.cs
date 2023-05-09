using System;
using System.Collections.Generic;
using System.Text;
using algoritmo_login.Cadastro;
using algoritmo_login.User;

namespace algoritmo_login.Menu
{
    public class MenuUser
    {

        public MenuUser () {}

        public void MenuUsuario()
        {
            bool validacao = true;

            while (validacao)
            {
                Console.WriteLine("-----------------------CENTRAL----------------");
                Console.WriteLine("INFORME SE VOCE DESEJA: ");
                Console.WriteLine("1 - REALIZAR LOGIN");
                Console.WriteLine("2 - REALIZAR CADASTRO");
                Console.Write("RESPONDA: ");

                string opcaoUsuario = Console.ReadLine();
                switch (opcaoUsuario)
                {
                    case "1": validacao = false; Console.WriteLine("VOCE NAO POSSUI CADASTRO"); ValidacaoLogin(); break;
                    case "2": Console.Clear(); DadosCadastro(); validacao = false; Callback(); break;
                    default: Console.Clear(); Console.WriteLine("Por favor, digite 1 ou 2!"); break;
                }
            }
        }

        public void Callback()
        {
            Console.Clear();
            MenuUsuario();
        }

        public void ValidacaoLogin()
        {
            bool validacao = true;
            while (validacao) {
                Console.Clear();
                Console.WriteLine("--------------LOGIN USUARIO--------------");
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                if (email == "admin" && senha == "admin")
                {
                    Console.WriteLine("ENTROU");
                }
                else
                {
                    Console.WriteLine("ERRO TENTE NOVAMENTE");
                }

            }
        }

        public void DadosCadastro()
        {
            Cadastro.CadastroUser.CadastroUsuario();
        }

    }
}
