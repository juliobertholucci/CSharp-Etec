using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_maio__IF_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Informe o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O número " + n1 + " é maior que " + n2);
            }

            else if (n1 == n2)
            {
                Console.WriteLine("O número " + n1 + " é igual a " + n2);
            }

            else
            {
                Console.WriteLine("O número " + n2 + " é maior que " + n1);
            }

            Console.ReadKey();



























































        }
    }
}
