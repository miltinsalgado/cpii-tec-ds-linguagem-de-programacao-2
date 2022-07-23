using System;

namespace Questão_15_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 15-Lista 01");

            Console.WriteLine("Entre com a nota obtida em Física:\t");
            double nota_fis = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com a nota obtida em Química:\t");
            double nota_qui = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com a nota obtida em Matemática:\t");
            double nota_mat = Convert.ToDouble(Console.ReadLine());

            double total = nota_mat + nota_fis + nota_qui;

            if ((nota_mat >= 65) && (nota_fis >= 55) && (nota_qui >= 50))
            {
                if (total >= 180)
                {
                    Console.WriteLine("O aluno está apto a cursar Ciência da Computação.");
                }
                else
                {
                    Console.WriteLine("O aluno não está apto a cursar Ciência da Computação.");
                }
            }
            else
            {
                Console.WriteLine("O aluno não está apto a cursar Ciência da Computação.");
            }

            Console.ReadLine();
        }
    }
}
