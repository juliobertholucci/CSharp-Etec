using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            Console.WriteLine("Informe o valor de A:");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B:");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C:");
            C = double.Parse(Console.ReadLine());

            if (A < B && B < C)
            {
                Console.WriteLine("Está em ordem crescente! " + A + " , " + B + " , " + C);
            }

            else if (A < C && C < B)
            {
                Console.WriteLine("Está em ordem crescente! " + A + " , " + C + " , " + B);
            }

            else if (A < C && C < B)
            {
                Console.WriteLine("Está em ordem crescente! " + B + " , " + A + " , " + C);
            }

            else if (B < A && A < C)
            {
                Console.WriteLine("Está em ordem crescente! " + B + " , " + C + " , " + A);
            }

            else if (B < C && C < A)
            {
                Console.WriteLine("Está em ordem crescente! " + C + " , " + A + " , " + B);
            }

            else if (C < A && A < B)
            {
                Console.WriteLine("Está em ordem crescente! " + C + " , " + B + " , " + A);
            }

            else
            {
                Console.WriteLine("Não se encaixa nos itens.");
            }

            Console.ReadKey();























































































































































































        }
    }
}
