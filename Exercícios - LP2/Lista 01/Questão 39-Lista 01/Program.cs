using System;

namespace Questão_39_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 39-Lista 01");

            Console.WriteLine("Entre com um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 2 || num == 3 || num == 5 || num == 7)
                Console.WriteLine(num + " é um número primo.");

            else if (num % 2 == 0 & num % 3 == 0 & num % 5 == 0 & num % 7 == 0)
                Console.WriteLine(num + " é um número primo.");

            else
                Console.WriteLine(num + " não é um número primo.");

            Console.ReadLine();
        }
    }
}
