using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, senha, nome;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe seu login:");
            login = Console.ReadLine();
                        Console.WriteLine("Informe sua senha:");
            senha = Console.ReadLine();
            
            if (login == nome && senha == "etec")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Acesso permitido!");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Acesso negado!! Login e/ou senha errado!");
            }

            Console.ReadKey();






















































































































































        }
    }
}
