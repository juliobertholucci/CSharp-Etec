using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_tenteadivinhar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, sorteado;
            Console.WriteLine("Números vão de 0 a 10");
            Console.WriteLine("Informe o primeiro número:");
            numero = int.Parse(Console.ReadLine());
            

            Random sorteio = new Random();
            sorteado = sorteio.Next(0, 11);
            for (int i = 1; i <= 3; i++)
            {
                if (numero == sorteado)
                {
                    Console.WriteLine("VC ganhou!");
                    break;
                }

                else
                {
                    if (i < 3)
                    {
                        Console.Clear();
                        if(sorteado>numero)
                        Console.WriteLine("Vc errou, tente novamente!");
                        else
                            Console.WriteLine("Vc errou, tente um n maio");
                    }

                    else
                    {
                        Console.WriteLine("Vc excedeu o número de tentativas!");
                        Console.WriteLine("O sorteado foi " +sorteado);
                    }

                   
                }

                Console.ReadKey();
                
                    

                
                

                                




            }





        }
    }
}
