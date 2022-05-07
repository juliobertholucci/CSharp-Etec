using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_IMC_EOU
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Informe seu peso:");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura:");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc);

            if (imc >= 0 && imc < 18.5)
            {
                Console.WriteLine("Você esta ABAIXO DO PESO");
            }

            else if (imc >= 18.5 && imc < 24.99)
            {
                Console.WriteLine("Você está no Peso Ideal");
            }

            else if (imc >= 24.99 && imc < 29.99)
            {
                Console.WriteLine("Você ESTÁ GORDO");
            }

            else if (imc >= 30 && imc < 34.99)
            {
                Console.WriteLine("Você ESTÁ MUITO GORDO");
            }

            else if (imc >= 35 && imc < 39.99)
            {
                Console.WriteLine("Você ESTÁ MUITOOOO GORDOOO");
            }

            Console.WriteLine("Obrigado por usar o programa!");

            Console.ReadKey();


























        }
    }
}
