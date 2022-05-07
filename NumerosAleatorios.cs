using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_NumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random Sorteio = new Random();
            int NumeroSorteado = Sorteio.Next(0, 61);
            int NumeroSorteado2 = Sorteio.Next(0, 61);
            int NumeroSorteado3 = Sorteio.Next(0, 61);
            int NumeroSorteado4 = Sorteio.Next(0, 61);
            int NumeroSorteado5 = Sorteio.Next(0, 61);
            int NumeroSorteado6 = Sorteio.Next(0, 61);
            //instanciando, criando um novo objeto de classe random 
            //esse objeto será capaz de gerar um número aleatório entre o intervalo numerico definido no next
            Console.WriteLine("O número sorteado foi: " + NumeroSorteado);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("O número sorteado foi: " + NumeroSorteado2);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("O número sorteado foi: " + NumeroSorteado3);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("O número sorteado foi: " + NumeroSorteado4);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("O número sorteado foi: " + NumeroSorteado5);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("O número sorteado foi: " + NumeroSorteado6);
            System.Threading.Thread.Sleep(1000);


            Console.WriteLine("Pressione qualquer tecla para sair");


            

            Console.ReadKey();


































        }
    }
}
