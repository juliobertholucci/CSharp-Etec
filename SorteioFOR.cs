using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_sorteioFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            int impar = 0;
            int numerosorteado;
            Random Sorteio = new Random();

            for (int x = 1; x <= 100; x++)
            { 
             numerosorteado = Sorteio.Next(1,1001);
             if (numerosorteado % 2 == 0)
             {
                 Console.WriteLine(" O número sorteado é par " + numerosorteado);
                 par++;
             }

             else
             {
                 Console.WriteLine("O número sorteado é ímpar " +numerosorteado);
                 impar++;
             
             }

            }
            Console.WriteLine("Pares sorteados: " +par);
            Console.WriteLine("Impares sorteados: " +impar);
            Console.ReadKey();







        }
    }
}
