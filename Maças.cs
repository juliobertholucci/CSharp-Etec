using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Maçaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
                double total;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.Write("Informe a quantidade de maçãs compradas:");
            quantidade = int.Parse(Console.ReadLine());

            if(quantidade >=12)
            {
                total = quantidade * 1.00;
                Console.Write("O valor total da compra é: " + total.ToString("C") );
            }

            else
            {
                total = quantidade * 1.10;
                Console.Write("O valor total da compra é " + total.ToString("C") );
            }
            Console.ReadKey();


            


















































        }
    }
}
