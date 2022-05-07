using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_While3
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = "sim";
            while (w == "sim")
            {
                /*int n1, n2, n3, n4, n5;

                do 
                {
                    Console.WriteLine("n1:");
                    n1 = int.Parse(Console.ReadLine());
                }while (n1 > 70);

                do
                {
                    Console.WriteLine("n2:");
                    n2 = int.Parse(Console.ReadLine());
                } while (n2 > 70);

                do
                {
                    Console.WriteLine("n3:");
                    n3 = int.Parse(Console.ReadLine());
                } while (n3 > 70);

                do
                {
                    Console.WriteLine("n4:");
                    n4 = int.Parse(Console.ReadLine());
                } while (n4 > 70);

                do
                {
                    Console.WriteLine("n5:");

                    n5 = int.Parse(Console.ReadLine());
                } while (n5 > 70); */




                Random Sorteio = new Random();
                int nmSorteado = Sorteio.Next(0, 71);
                int nmSorteado2 = Sorteio.Next(0, 71);
                int nmSorteado3 = Sorteio.Next(0, 71);
                int nmSorteado4 = Sorteio.Next(0, 71);
                int nmSorteado5 = Sorteio.Next(0, 71);
                double total, total2;
                Console.WriteLine("5 Números serão sorteados de 0 a 70");
                Console.WriteLine("\nNúmero 1: " + nmSorteado);
                Console.WriteLine("\nNúmero 2: " + nmSorteado2);
                Console.WriteLine("\nNúmero 3: " + nmSorteado3);
                Console.WriteLine("\nNúmero 4: " + nmSorteado4);
                Console.WriteLine("\nNúmero 5: " + nmSorteado5);
                total = nmSorteado + nmSorteado2 + nmSorteado3 + nmSorteado4 + nmSorteado5;
                Console.WriteLine("Soma: " + total);
                total2 = Math.Sqrt(total);
                Console.WriteLine("Raiz quadrada: " + total2);
                if (total2 < 0)
                {
                    Console.WriteLine("A raiz não existe!");
                }


                if (total2 % 2 == 0)
                {
                    Console.WriteLine("O número é par! " +total2);
                }

                else
                {
                    Console.WriteLine("O número é ímpar " + total2);
                }
                Console.WriteLine("Deseja começar o programa novamente?(sim/nao)");
                w = Console.ReadLine().ToLower();
                Console.Clear();
            }
            Console.WriteLine("Obrigado!");
            System.Threading.Thread.Sleep(2000);


































































































        }
    }
}
