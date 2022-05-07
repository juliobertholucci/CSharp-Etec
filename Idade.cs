using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Bem-Vindo ao DETRAN");
            Console.Write("Pressione ENTER para começar");

            Console.Clear();
            Console.Write("Nos informe seu nome completo:");
            nome = Console.ReadLine();

            Console.Clear();

            Console.Write(nome + " informe sua idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.Write(nome + " você está apto para dirigir");
            }

            else
            {
                Console.Write(nome + " você não está apto para dirigir");
            }

            Console.ReadKey();

            



















































        }
    }
}
