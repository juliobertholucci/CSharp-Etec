using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Júlio
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string senha = "#provaDeLogica";

            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe sua senha:");

            Console.Clear();

            if (senha == "#provaDeLogica")
            {
                string valor = "sim";
                Console.WriteLine("Qual o preço do produto?");
                int produto = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Você possuí esse valor?");
                valor = Console.ReadLine();
                if (valor == "sim")
                {
                    Console.WriteLine("Ok! Compra efetuada com sucesso!");

                }

                double desconto1;
                desconto1 = produto - (5 / 100);
            

            else if (desconto1 <= produto)
            {
                Console.WriteLine("OK! gostei de você, vou te dar um desconto de 5%!");
            }

            else if (desconto1 >= produto)
            {
                double desconto2;
                desconto2 = produto - (10 / 100);

                if (desconto2 >= produto)
                {
                    Console.WriteLine("OK! Gostei de você, vou te dar um desconto de 10%!");
                }

                else if (desconto2 <= produto)
                {
                    double desconto3;
                    desconto3 = produto - (15 / 100);

                    if (desconto3 <= produto)
                    {
                        Console.WriteLine("OK! Gostei de você, vou te dar um desconto de 15%!");
                    }
                }

                else
                {
                    for (int n = 0; n <= 10; n++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Desculpe, não posso vender esse produto para você!Volte mais tarde com dinheiro!");

                    }

                }

                Console.ReadKey();



            }





























































            }
        }
}   }
