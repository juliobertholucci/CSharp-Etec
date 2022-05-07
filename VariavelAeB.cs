using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variavél_a_e_b
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Clear();

            Console.Write("Informe o valor de A:");
            a = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.Write("Informe o valor de B:");
            b = double.Parse(Console.ReadLine());
            Console.Clear();

            c = a;
            a = b;
            b = c;

            Console.WriteLine("=O novo valor de b é: " + b + " =");
            Console.WriteLine("=O novo valor de a é: " + a + " =");
            Console.ReadKey();
            

            


























































        }
    }
}
