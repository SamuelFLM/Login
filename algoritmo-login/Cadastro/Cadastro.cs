using algoritmo_login.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace algoritmo_login.Cadastro
{
    public class Cadastro
    {
        public Cliente cliente { get; set; }
        public Register register { get; set; }  

        public Cadastro() { }
        public void CadastroUsuario()
        {
            Console.WriteLine("Olá, bem-vindo!!\nPara Começar informe seu nome.");
            Console.Write("Nome: ");
            string nomeUsuario = Console.ReadLine();
            Console.WriteLine($"Show de bola {nomeUsuario}, agora me infome sua idade.");
            bool validacaoValor = true;

            byte idadeUsuario = 0;
            while (validacaoValor)
            {
                try
                {
                    Console.Write("Idade: ");
                    idadeUsuario = byte.Parse(Console.ReadLine());
                    validacaoValor = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("ERRO, Digite um número inteiro!!");
                }
            }
            Console.Clear();
            Console.WriteLine($"Legal demais {nomeUsuario}!! Agora bora registra seu e-mail e senha.");

            string[] emailESenha = { "E-mail: ", "Senha: " };
            List<string> dadosUsuario = new List<string>();

            for (int i = 0; i < emailESenha.Length; i++)
            {
                Console.Write(emailESenha[i]);
                dadosUsuario[i] = Console.ReadLine();
            }


        }

        public static Register cadastroUsuario(string email, string senha)
        {
            return new Register(email, senha);
        }
    }

}
