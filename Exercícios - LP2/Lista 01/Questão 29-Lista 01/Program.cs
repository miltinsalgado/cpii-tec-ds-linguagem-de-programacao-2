using System;

namespace Questão_29_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 29-Lista 01");

            double soma = 0;
            int i = 0;
            while(i!=1)
            {
                Console.WriteLine("Digite um número:");
                double num = Convert.ToDouble(Console.ReadLine());
                soma += num;
                Console.WriteLine("Quer continuar digitando?");
                char resposta = Convert.ToChar(Console.ReadLine());
                if (resposta == 'n')
                {
                    i = 1;
                }
            }
            Console.WriteLine("A soma vale " + soma);

            Console.ReadLine();
        }
    }
}
