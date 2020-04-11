using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrei
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome;
            nome = new string[4];
 
            nome[0] = "wallace";
            nome[1] = "gomes";
            nome[2] = "andrade";
            nome[3] = "hyro";

            for (int i = 0; i < 4; i++)
            {
              Console.Write(nome[i]);
              Console.Write(" ");
            }
            Console.ReadKey();

        }
    }
}
