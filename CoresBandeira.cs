using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Cores_Bandeira
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor;

            Console.WriteLine("Informe a cor:");
            cor = Console.ReadLine();

            if (cor == "Vermelho" || cor == "Amarelo" || cor == "Verde" || cor == "Azul" || cor == "Branco")
            {
                Console.WriteLine("Você digitou uma cor que tem na bandeira:");
            }

            else
            {
                Console.WriteLine("Você não digitou nenhuma cor que tem na bandeira!");
            }

            Console.ReadKey();




























        }
    }
}
