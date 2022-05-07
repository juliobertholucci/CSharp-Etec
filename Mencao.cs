using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_Menção
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, media, nota3;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine("Informe a primeira nota:");
            nota1 = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Informe a segunda nota:");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota:");

            nota3 = int.Parse(Console.ReadLine());

            media = nota1 + nota2 + nota3 / 2;

            if (media >= 9)
            {
                Console.WriteLine("A média das notas teve a menção MB");
            }

            else if (media >= 8)
            {
                Console.WriteLine("A média das notas teve a menção B");
            }

            else if (media >= 5)
            {
                Console.WriteLine("A média das notas teve a menção R");
            }

            else
            {
                Console.WriteLine("A média das notas teve a menção I");
            }

            Console.ReadKey();


























        }
    }
}
