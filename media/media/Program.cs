using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1;
            double nota2;
            double nota3;
            double nota4;
            double media;

            Console.Write(" entre com o nome do aluno :");
            nome = Console.ReadLine();

            Console.Write(" entre com a nota do primeiro bimestre :");
            nota1 = Convert.ToDouble( Console.ReadLine());

            Console.Write(" entre com a nota do segundo bimestre :");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" entre com a nota do terceiro bimestre :");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" entre com a nota do Quarto bimestre :");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 5) 
            {
                Console.Write(nome + " foi aprovado com "+media);
            }

            else
            {
                Console.Write(nome + " foi reprovado com "+media);
            }

            Console.ReadKey();
        }
    }
}
