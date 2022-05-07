using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velocidade_média
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double distancia, tempo, vm;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear
            Console.Write("Por favor, nos informe seu nome:");
            nome = Console.ReadLine();

            Console.Clear();

            Console.Write("Informe a distância que você percorreu:");
            distancia = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.Write("Informe o tempo decorrido durante a viagem dos " + distancia + "km:");
            tempo = double.Parse(Console.ReadLine());

            vm = distancia / tempo;

            Console.Clear();

            Console.WriteLine("Sua velocidade média foi de: " + vm);

            Console.Write("Pressione Q para sair");

            Console.ReadLine();

            Console.ReadKey();







































        }
    }
}
