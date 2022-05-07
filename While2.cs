using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_while2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            double n1, n2, total;
            double n3;
            string r = "sim";
            while (r == "sim")
            {
                n3 = 0;
                Console.WriteLine("\nInforme o primeiro número:");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme o segundo número:");
                n2 = double.Parse(Console.ReadLine());


                while (n3 == 0)
                {
                    Console.WriteLine("\nInforme o terceiro número:");
                    n3 = double.Parse(Console.ReadLine());

                }

                total = (n1 + n2) / n3;
                Console.WriteLine("Resultado final: " + total);
                Console.WriteLine("\n Deseja repetir o processo?(sim/nao)");
                r = Console.ReadLine().ToLower();
                Console.Clear();
            }
            Console.WriteLine("O programa será fechado");
            System.Threading.Thread.Sleep(2000);
            
















        }
    }
}
