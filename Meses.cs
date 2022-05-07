using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Informe o mês em número:");
            mes = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("Esse mês possuí 31 dias");
            }

            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("Esse mês possuí 30 dias");
            }

            else if (mes == 2)
            {
                Console.WriteLine("Esse mês possuí 28 dias");
            }

            else
            {
                Console.WriteLine("O mês informado não existe");
            }
            Console.ReadKey();



            


























        }
    }
}
