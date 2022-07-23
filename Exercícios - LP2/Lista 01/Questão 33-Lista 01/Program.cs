using System;

namespace Questão_33_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 33-Lista 01");

            Console.WriteLine("Entre com o número cujo fatorial será calculado:\n");
            int num = Convert.ToInt32(Console.ReadLine());
            int fatorial = 0;

            for (int i = num; i > 0; i--)
            {
                if (i == num)
                    fatorial = num;
                else
                    fatorial *= i;
            }
            Console.WriteLine("O fatorial do número " + num + " é " + fatorial);
            Console.ReadLine();
        }
    }
}
