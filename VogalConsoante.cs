using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_Vogal_consoante
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;
            string continuar = "S";
            while (continuar == "S")
            {
                Console.WriteLine("Digite uma letra do alfabeto");
                letra = Console.ReadLine().ToUpper();

                switch (letra)
                {
                    case "A":
                    case "E":
                    case "I":
                    case "O":
                    case "U":
                        Console.WriteLine("A letra é uma vogal");
                        break;
                    default:
                        Console.WriteLine("A letra digitada é consoantes!");
                        break;
                }

                Console.WriteLine("Deseja informar outra letra (S/N)?");
                continuar = Console.ReadLine();







            }
        }
    }
}
