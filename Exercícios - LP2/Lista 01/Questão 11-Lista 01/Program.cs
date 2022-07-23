using System;

namespace Questão_11_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 11-Lista 01");

            Console.WriteLine("Entre com uma idade para verificação de permissão para dirigir:\t");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine("Parabéns! Você tem permissão para dirigir!");
            else
                Console.WriteLine("Desculpe! Você não tem permissão para dirigir!");

            Console.ReadLine();
        }
    }
}
