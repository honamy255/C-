using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomePessoa;
            string sobreNome;


            //escreva
            Console.Write("digite seu nome :");
            //leia
            nomePessoa = Console.ReadLine();

            //escreva
            Console.Write("digite seu sobre nome :");
            //leia
            sobreNome = Console.ReadLine();


            //escreva obs:sinal + unifica os atributos
            Console.WriteLine("o nome escrito foi :" + nomePessoa + " " + sobreNome);

            //para a tela ate que seje feito algo
            Console.ReadKey();


        }
    }
}
