using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positivo_negativo_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int numero;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Diga seu nome:");
            nome = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Digite o número:");
            numero = int.Parse(Console.ReadLine());

            Console.Clear();

            if (numero > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("O número informado " + numero + " é positivo");
            }

            else if (numero==0)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
             Console.WriteLine("O número informado " + numero + " é neutro");
            }
            
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O número informado " + numero + " é negativo");
            }

            Console.ReadKey();

           

























































        }
    }
}
