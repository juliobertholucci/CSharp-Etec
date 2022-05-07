using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_MédiaEOU
{
    class Program
    {
        static void Main(string[] args)
        {  
                string nome;
                double n1, n2, n3, n4, nfinal;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Bem-Vindo ao NSA Professor!");
                Console.Write("Informe seu nome:");
                nome = Console.ReadLine();
                Console.ReadLine();
                Console.Clear();

                Console.Write("Informe a nota 1:");
                n1 = double.Parse(Console.ReadLine());

                Console.Clear();

                Console.Write("Informe a nota 2:");
                n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a nota 3:");
                n3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a nota 4:");

                n4 = double.Parse(Console.ReadLine());

                nfinal = (n1 + n2 + n3 + n4) / 4;

                if (nfinal >= 0 && nfinal < 4.99)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("A nota informada: " + nfinal + " é I");
                }

                else if (nfinal >= 4.99 && nfinal < 7.99)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("A nota informada: " + nfinal + " é R");
                }

                else if (nfinal >= 8 && nfinal < 9.99)
                {
                    Console.WriteLine("A nota informada " + nfinal + " é B ");
                }

                else if (nfinal == 10)
                {
                    Console.WriteLine("A nota informada " + nfinal + " é MB ");
                }


                Console.ReadKey();


































            
        }
    }
}








  
