using System;

namespace Questão_10_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 10-Lista 01");

            Console.WriteLine("Digite um número no qual será relizado o estudo de sinal:\t");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num<0)
                Console.WriteLine(num + " é um número negativo");
            else
                Console.WriteLine(num + " é um número positivo");

            Console.ReadLine();
        }
    }
}
