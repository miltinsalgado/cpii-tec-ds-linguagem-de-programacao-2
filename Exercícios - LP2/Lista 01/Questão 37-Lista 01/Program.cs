using System;

namespace Questão_37_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 37-Lista 01");

            Console.WriteLine("Digite um número:");
            int num = Convert.ToInt32(Console.ReadLine());
            int soma = 0;
            Console.WriteLine("Os divisores positivos de " + num + " são:");
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                    soma += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("A soma dos divisores vale: " + soma);
            if (soma == num)
                Console.WriteLine("O número, portanto, é perfeito.");
            else
                Console.WriteLine("O número, portanto, não é perfeito.");
            Console.ReadLine();
        }
    }
}
