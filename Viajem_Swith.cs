using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_viajem_swith
{
    class Program
    {
        static void Main(string[] args)
        {
            int pessoas;
            Console.WriteLine("Quantas pessoas irão viajar?");
            pessoas = int.Parse(Console.ReadLine());

            switch (pessoas)
            {
                case 1:
                    Console.WriteLine("Vai de moto");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Vai de carro");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("Vai de van");
                    break;
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31:
                case 32:
                    Console.WriteLine("Vai de microonibus");
                    break;
                case 33:
                case 34:
                case 35:
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                case 48:
                case 49:
                case 50:
                    Console.WriteLine("Vai de onibus");
                    break;

            }
            Console.ReadKey();




















        }
    }
}
