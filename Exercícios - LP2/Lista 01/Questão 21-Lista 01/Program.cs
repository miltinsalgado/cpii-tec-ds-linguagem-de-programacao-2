using System;

namespace Questão_21_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 21-Lista 01");

            Console.WriteLine("Digite um número inteiro entre 1 e 7:\t");
            int dia = Convert.ToInt32(Console.ReadLine());

            if (dia == 1)
                Console.WriteLine("Domingo.");
            else if (dia == 2)
                Console.WriteLine("Segunda.");
            else if (dia == 3)
                Console.WriteLine("Terça.");
            else if (dia == 4)
                Console.WriteLine("Quarta.");
            else if (dia == 5)
                Console.WriteLine("Quinta.");
            if (dia == 6)
                Console.WriteLine("Sexta.");
            else if (dia == 7)
                Console.WriteLine("Sábado.");
            else if (dia < 1 || dia > 7)
                Console.WriteLine("Dia inválido.");

            Console.ReadLine();
        }
    }
}
