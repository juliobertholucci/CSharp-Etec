using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, raizD, x1, x2;//variável das contas
            string nome;//variável nome

            Console.BackgroundColor = ConsoleColor.White;//trocando o fundo da tela
            Console.ForegroundColor = ConsoleColor.DarkCyan;//trocando a cor da tela
            Console.Clear();//Limpando tela
            Console.Write("Informe seu nome:");//pedindo nome
            nome = Console.ReadLine();//salvando nome
            Console.Clear();//limpando tela

            Console.Write("Informe o valor de A:");//pedindo valor de a 
            a = double.Parse(Console.ReadLine());//salvando valor de a

            Console.Clear();//limpando console

            Console.Write("Informe o valor de B:");//pedindo valor de b
            b = double.Parse(Console.ReadLine());//salvando valor de b

            Console.Clear();//limpando console

            Console.Write("Informe o valor de C:");//pendindo valor de c
            c = double.Parse(Console.ReadLine());//salvando valor de c

            Console.Clear();//limpando console

            delta = (b * b) - 4 * (a * c);//conta do delta
            //ou delta = Math.Pow (b, (nº que quiser elevar a potencia) )
    
           
            if (delta >= 0) //condição se a raiz for maior que 0
            {
                raizD = Math.Sqrt(delta);//obtendo a raiz de delta//Math->Biblioteca matemática
                x1 = (-b + raizD) / (2 * a);//processamento
                x2 = (-b - raizD) / (2 * a);//processamento
                Console.WriteLine("O valor de Delta é: " + delta);//dando o valor de delta
                Console.Write("O valor de x1 e x2 são respectivamente: " + x1 + " e " + x2);//dando o valor de x1 e x2
            }    
            
            else//condição lógica 
            {
                Console.Write("Não existe x1 e x2 pois a raiz não é positiva " + delta);//mostrando que não é possível e dando o valor de delta
            }

            Console.ReadKey();//finalizando o programa













































































        }
    }
}
