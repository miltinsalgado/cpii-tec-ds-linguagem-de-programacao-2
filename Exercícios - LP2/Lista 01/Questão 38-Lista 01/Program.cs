using System;

namespace Questão_38_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 38-Lista 01");

            Console.WriteLine("Entre com um número: ");

            string num = Console.ReadLine();
            int soma = 0, ch = 0;

            for (int i = 0; i < num.Length; i++)
            {
                ch = Convert.ToInt32(Convert.ToString(num[i]));
                soma += Convert.ToInt32(Math.Pow(ch, 3));
            }
            if (soma == Convert.ToInt32(num))
                Console.WriteLine(num + " é um número Armstrong.");
            else
                Console.WriteLine(num + " não é um número Armstrong.");

            Console.ReadLine();
        }
    }
}