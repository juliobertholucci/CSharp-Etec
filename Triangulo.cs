using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double L1, L2, L3;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.WriteLine("Informe o lado 1:");
            L1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o lado 2:");
            L2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o lado 3:");
            L3 = double.Parse(Console.ReadLine());
            
            if ((L1 + L2) > L3 && (L2 + L3) > L1 && (L1 + L3) > L2)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (L1 == L2 && L2 == L3)
                {
                    Console.WriteLine("É um triângulo equilátero");
                }

                else if (L1 != L2 && L2 != L3 && L3 != L1)
                {
                    Console.WriteLine("É um triângulo escaleno");
                }

                else
                {
                    Console.WriteLine("É um triângulo isósceles");
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é um triângulo!");
            }

            Console.ReadKey();



































        }
    }
}
