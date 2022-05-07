using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Opçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            
            Console.WriteLine("Qual a resposta para tudo?");
            resposta = int.Parse(Console.ReadLine());
            string continua;

            if (resposta == 42)
            {
                do
                {
                   
                    Console.WriteLine("Boa-Tarde Seja Bem-Vindo");
                    Console.WriteLine("Digite a opção escolhida:");
                    Console.WriteLine("1-Calcular a 25º potencia de um número");
                    Console.WriteLine("2-Calcular DELTA");
                    Console.WriteLine("3-Calcular a tabuada de um número");
                    Console.WriteLine("4-Calcular o desconto de 7,5% de um produto(R$)");
                    int opcao;
                    opcao = int.Parse(Console.ReadLine());

                    if (opcao == 1)
                    {
                        CalcularPotencia();


                    }

                    else if (opcao == 2)
                    {
                        CalcularDelta();
                    }

                    else if (opcao == 3)
                    {
                        CalcularTabuada();
                    }

                    else if (opcao == 4)
                    {
                        CalcularDesconto();
                    }

                    else
                    {
                        Console.WriteLine("Resposta inválida!");

                    }
                    Console.WriteLine("Deseja executar novamente?");
                     continua = Console.ReadLine();
                    Console.Clear();
                    
                } while (continua == "sim");

                Console.WriteLine("Obrigado!");
                System.Threading.Thread.Sleep(2000);
            }
            else
            {

                for (int repe = 0; repe <= 100; repe++)
                {
                    Console.WriteLine(repe + " Você não é Bem-Vindo");

                }
                Console.ReadLine();
                Environment.Exit(0);


            }



     
            

        }

        //metodo para calcular 25ª potencia
        public static void CalcularPotencia()
        {
            double numero, potencia;
            Console.WriteLine("\nCALCULAR A 25ª POTENCIA");
            Console.WriteLine("Informe o valor:");
            numero = double.Parse(Console.ReadLine());
            potencia = Math.Pow(numero, 25);
            Console.WriteLine("O valor é: " + potencia);
            Console.ReadKey();
        }








        public static void CalcularDelta()
        {
            Console.WriteLine("Informe a letra A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a letra B:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o a letra C:");
            int c = int.Parse(Console.ReadLine());
            double delta = (b * b) - 4 * a * c;
            Console.WriteLine("O valor de delta é: " +delta);
            if (delta >= 0)
            {
                Console.WriteLine("X1 e X2");
                double raiz = Math.Sqrt(delta);
                double x1 = (-b + raiz) / (2 * a);
                double x2 = (-b - raiz) / (2 * a);
                Console.WriteLine("A raiz é: " + raiz);
                Console.WriteLine("O X1 é: " + x1);
                Console.WriteLine("O X2 é : " + x2);
            }
            else
                Console.WriteLine("A raiz não existe!");
            Console.ReadKey();
            

        }

        public static void CalcularTabuada()
        {
            Console.WriteLine("Informe o número da tabuada desejada:");
            int num = int.Parse(Console.ReadLine());
            int resultado;
            for (int vezes = 0; vezes <= 10; vezes = vezes + 1)
            {
                resultado = num * vezes;
                Console.WriteLine(num + " x " + vezes);

            }
            Console.ReadKey();             
        }

        public static void CalcularDesconto()
        {
            Console.WriteLine("Informe o valor do produto: R$");
            double valor = double.Parse(Console.ReadLine());
            double desconto = valor - (7.5 / 100);
            Console.WriteLine("O desconto atribuído (7,5%) resultará num preço de: " +desconto);
            Console.ReadKey();
                       
        }























































    }




}


