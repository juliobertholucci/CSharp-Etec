using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_exercicioSorteio
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Random sorteio = new Random();
            int numero = sorteio.Next(-100, 100);

            Console.WriteLine("Estamos sorteando o número...Aguarde...");
            System.Threading.Thread.Sleep(3000);

            

            if (numero >= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("O número do sorteio " + numero + " é positivo");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O número sorteado " + numero + " é negativo!");
            }

            Console.ReadKey();

























        }
    }
}
