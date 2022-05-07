using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Desconto_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorProduto, total, pgto;
            string nomeProduto;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Informe o nome do produto:");
            nomeProduto = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Informe o valor do produto R$:");
            valorProduto = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("A forma de pagamento que você quer: 1- À vista ou 2- À prazo");

            pgto = double.Parse(Console.ReadLine());

            if (pgto == 1)
            {
                total = valorProduto - (valorProduto * 10 / 100);
                Console.Write("O valor do produto a vista é: " + total.ToString("C"));
            }

            else
            {
                total = valorProduto + (valorProduto * 5 / 100);
                Console.Write("O valor do produto a prazo é: " + total.ToString("c"));
            }
            Console.ReadKey();


















































































































































































































































































































        }
    }
}
