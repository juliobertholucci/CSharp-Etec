using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Julio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "#prova";
            string res = "sim";
            double desconto1, desconto2, desconto3;
            double preço;

            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Senha:");
            senha = Console.ReadLine();
            if (senha == "#prova")
            {
                Console.WriteLine("Informe o preço do produto:");
                int produto = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Você possui esse valor?");
                res = Console.ReadLine();
                if (res == "sim")
                {
                    Console.WriteLine("Produto adquirido com sucesso!");
                }

                else if (res == "nao")
                {
                    Console.WriteLine("Qual o valor que vc possui?");
                    preço = double.Parse(Console.ReadLine());

                    desconto1 = produto * (5 / 100);
                    double descontof1 = produto - desconto1;
                    if (descontof1 <= preço)
                    {
                        Console.WriteLine("Gostei de vc, vou te dar um desconto de 5%!");
                        Console.WriteLine("Vc adquiriu o produto com sucesso!");
                    }

                    else if (descontof1 > preço)
                    {
                        desconto2 = produto * (10 / 100);
                        double descontof2 = desconto2 - produto;
                        if (descontof2 <= produto)
                        {
                            Console.WriteLine("Gostei de vc, vou te dar um desconto de 10%!");
                            Console.WriteLine("Vc adquiriu o produto com sucesso!");
                        }


                        else if (descontof2 > preço)
                        {
                            desconto3 = produto * (15 / 100);
                            double descontof3 = desconto3 - produto;
                            Console.WriteLine("Gostei de vc, vou te dar um desconto de 15%!");
                            Console.WriteLine("Vc adquiriu o produto com sucesso!");
                        }

                        else
                        {

                            for (int repe = 0; repe <= 10; repe++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Não posso vender esse produto para vc, Volte com mais dinheiro!");

                            }

                        }
                    }

                }



            }
            else
            {
                Console.WriteLine("Senha errada!");
            }

            Console.ReadKey();







































        }













































    }
}

