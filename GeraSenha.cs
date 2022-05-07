using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_GERASENHA
{
    class Program
    {
        static void Main(string[] args)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyzçABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@#$&*%,.;:><+=!?-/_ ";
            
            Random Sorteio = new Random();
            string senha = "";
            //Conta quantos caracteres tem a variável //Console.WriteLine(caracteres.Length);
            Console.WriteLine(caracteres.Substring(Sorteio.Next(0,caracteres.Length-1),1));
            


           for (int i = 1; i<=15; i++)
           {

               senha = senha +(caracteres.Substring(Sorteio.Next(0, caracteres.Length - 1), 1));

           }
           Console.WriteLine("A senha gerada foi " + senha);
           Console.ReadKey();




        }
    }
}
