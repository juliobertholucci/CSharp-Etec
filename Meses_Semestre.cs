using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_meses_semestre
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int mes;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Bem-Vindo ao NSA Professor!");
            Console.Write("Informe o seu nome:");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Informe o mês:");

            mes = int.Parse(Console.ReadLine());

            Console.Clear();

            if (mes <= 6)
            {
                Console.Write("O mês informado: " + mes + " pertence ao 1 Semestre");
            }

            else
            {
                Console.Write("O mês informado: " + mes + " pertence ao 2 Semestre");
            }

            Console.ReadKey();


















        }
    }
}
