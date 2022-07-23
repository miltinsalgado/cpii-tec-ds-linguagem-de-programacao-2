using System;

namespace Questão_06_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 06-Lista 01");

            Console.WriteLine("Entre com um número inteiro: ");
            double num_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com outro número inteiro: ");
            double num_2 = Convert.ToInt32(Console.ReadLine());

            double soma = num_1 + num_2;
            double diferença = num_1 - num_2;
            double produto = num_1 * num_2;
            double quociente = num_1 / num_2;

            Console.WriteLine("A Soma entre os números " + num_1 + " e " + num_2 + " é igual a: " + soma);
            Console.WriteLine("A Diferença entre os números " + num_1 + " e " + num_2 + " é igual a: " + diferença);
            Console.WriteLine("O Produto entre os números " + num_1 + " e " + num_2 + " é igual a: " + produto);
            Console.WriteLine("O Quociente entre os números " + num_1 + " e " + num_2 + " é igual a: " + quociente);

            Console.ReadLine();
        }
    }
}
