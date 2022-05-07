using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_positivo_negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.Write("Informe um número:");
            numero = int.Parse(Console.ReadLine());
            if (numero >= 0)
              
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("O número informado " + numero + " é positivo"); }

            else {
            
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O número informado " + numero + " é negativo"); }

            Console.ReadKey();




































        }
    }
}
