using System;

namespace Questão_36_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 36-Lista 01");

            Console.WriteLine("Entre com a altura do triângulo de Floyd:");
            int altura = Convert.ToInt32(Console.ReadLine());
            int cont = 1;
            for (int i = 1; i <= altura; i++)
            {
                for (int k = i; k > 0; k--)
                {
                    Console.Write(cont + " ");
                    cont++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
