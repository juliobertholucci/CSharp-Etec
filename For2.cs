using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_For2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Sorteio = new Random();
            int sorteado = Sorteio.Next(1, 16);
            int inicio, fim, total;
            Console.WriteLine("Informe o inicio da sua tabuada:");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o fim da sua tabuada:");
            fim = int.Parse(Console.ReadLine());
            if (fim < inicio)
            {
                Console.WriteLine("Valor inicial deve ser menor que final");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0); 
            }    
            else
            {

                for (int i = inicio; i <= fim; i++)
                {
                    Console.WriteLine("Tabuada do " + i);

                    for (int conta = 0; conta <= 10; conta++)
                    {
                        total = i * conta;
                        Console.WriteLine(i + " x " + conta + " = " + total);

                    }
                }
            }
              Console.ReadKey();










        }
    }
}
