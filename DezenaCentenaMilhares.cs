using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dezenas_Centenas_Milhares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Informe o número:");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero < 10)
            {
                Console.WriteLine("UNIDADE");
            }

            else if (numero >= 10 && numero < 100)
            {
                Console.WriteLine("DEZENA");
            }

            else if (numero >= 100 && numero < 1000)
            {
                Console.WriteLine("CENTENA");
            }

            if (numero >= 1000 && numero < 9999)
            {
                Console.WriteLine("MILHAR");
            }

            Console.ReadKey();





























        }
    }
}
