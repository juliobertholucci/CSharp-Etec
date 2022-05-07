using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_Média_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double n1, n2, nfinal;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Bem-Vindo ao NSA Professor!");
            Console.Write("Informe seu nome:");
            nome = Console.ReadLine();
            Console.ReadLine();
            Console.Clear();

            Console.Write("Informe a nota 1:");
            n1 = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.Write("Informe a nota 2:");
            n2 = double.Parse(Console.ReadLine());
            nfinal = n1 + n2 / 2;

            if (nfinal >= 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("A nota informada: " + nfinal + " está aprovado(a)");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("A nota informada: " + nfinal + " está reprovado(a)");
            }

            Console.ReadKey();

            





































        }
    }
}
