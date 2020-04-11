using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cauculos
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double soma;
            string operacao;


            Console.Write("digite o primeiro numero :");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite o sina :");
            operacao = Console.ReadLine();

            Console.Write("digite o segundo numero :");
            numero2 = Convert.ToDouble(Console.ReadLine());

            soma = 0;
            //condicao se entao 
            switch (operacao)

            {
                case "+": soma = numero1 + numero2;
                break;

                case "-": soma = numero1 - numero2;
                break;

                case "*": soma = numero1 * numero2;
                break;

                case "/": soma = numero1 / numero2;
                break;
                    
            }                 

            Console.WriteLine("o resultado foi :" + soma);

            Console.ReadKey();
        }
    }
}
