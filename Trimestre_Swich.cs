using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_trimestre_swich
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Sorteio = new Random();
            int mes = Sorteio.Next(1, 13);

            Console.WriteLine("o número sorteado é " + mes);

            switch (mes)
            { 
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Primeiro Trimestre");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Segundo Trimestre");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Terceiro Trimestre");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Quarto Trimestre");
                    break;
                                                          
            }

            Console.ReadKey();
            
          /*  if (mes ==1 || mes ==2 || mes ==3)
                Console.WriteLine("Primeiro trimestre");
                 
            else if (mes ==4 || mes ==5 || mes ==6)
                Console.WriteLine("Segundo trimestre");

            else if (mes ==7 || mes ==8 || mes ==9)
                Console.WriteLine("Terceiro trimestre");

            else if (mes == 10 || mes == 11 || mes == 12)
                Console.WriteLine("Quarto trimestre");
            Console.ReadKey(); */

        }
    }
}
