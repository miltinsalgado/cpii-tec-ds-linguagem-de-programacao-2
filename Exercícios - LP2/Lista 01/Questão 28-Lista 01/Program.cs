using System;

namespace Questão_28_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 28-Lista 01");

            Console.WriteLine("Qual número deseja calcular a tabuada?");
            double num = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                double produto = num * i;
                Console.WriteLine(num + " x " + i + " = " + produto);
            }

            Console.ReadLine();
        }
    }
}
