using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_opcoes_matematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao, nome;
            double n1, n2, resultado;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Primeiramente, nos informe seu nome:");
            nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Informe o primeiro número:");
            n1 = double.Parse(Console.ReadLine());

             Console.WriteLine("Informe o segundo número:");
             n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a conta matemática que você deseja (Divisão, Multiplicação, Soma & Subtração");
            opcao = Console.ReadLine().ToLower(); //.ToUpper() transforma em maiúculas // .ToLower() transforma tudo em minuscula
            Console.Clear();
                       
            if (opcao=="soma") 
            {
                resultado = n1 + n2;
                Console.WriteLine("O resultado da adição é " +resultado);
            }

            else if (opcao == "subtracao")
            {
                resultado = n1 - n2;
                Console.WriteLine("O resultado da subtração é " +resultado);
            }

            else  if (opcao == "divisao")
            {
             resultado = n1 / n2;
             Console.WriteLine("O resultado da divisão é " + resultado);
            }

            else if (opcao == "multiplicacao")
            {
                resultado = n1 * n2;
                Console.WriteLine("O resultado da multiplicação é " + resultado);
            }

            else
            {
            Console.WriteLine("Opção inválida!");
            }
            Console.ReadKey();








































































        }
    }
}
