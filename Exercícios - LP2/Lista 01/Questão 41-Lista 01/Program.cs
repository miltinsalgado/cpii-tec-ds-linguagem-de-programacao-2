using System;

namespace Questão_41_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 41-Lista 01");

            Console.WriteLine("Digite uma sequência de números: ");
            string seq =  Console.ReadLine();

            for (int i = seq.Length - 1; i >= 0; i--)
                Console.Write(seq[i]);

            Console.ReadLine();
        }
    }
}
