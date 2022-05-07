using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            string resposta = "sim";

            while (resposta == "sim")
            {
                double n1 = 11, n2 = 11, total;
                while (n1 > 10)
                {
                    Console.WriteLine("Digite um número:");
                    n1 = double.Parse(Console.ReadLine());
                    if (n1 > 10)
                    {
                        Console.WriteLine("Número inválido!\n");
                    }

                }
                while (n2 > 10)
                {
                    Console.WriteLine("Digite outro número:");
                    n2 = double.Parse(Console.ReadLine());

                    if (n2 > 10)
                    {
                        Console.WriteLine("Número inválido!\n");
                    }


                }
                total = n1 / n2;
                Console.WriteLine("Número 1: " + n1);
                Console.WriteLine("Número 2: " + n2);

                Console.WriteLine("Total da divisão: " +total );

                Console.WriteLine("\nDeseja executar novamente? (sim/nao):");
                resposta = Console.ReadLine().ToLower();
                Console.Clear();

            }
             
            Console.WriteLine("\nTchau...");
            System.Threading.Thread.Sleep(2000);
           


           








































































































        }
    }
}
