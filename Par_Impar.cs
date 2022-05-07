using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.Clear();
            Console.WriteLine("\n\ODigite um número:");
            numero = int.Parse(Console.ReadLine());
                      


            if (numero % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("O número informado é par!");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O número informado é ímpar!");
            }


            Console.ReadKey();













































        }
    }
}
