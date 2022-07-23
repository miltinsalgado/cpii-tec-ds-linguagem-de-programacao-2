using System;

namespace Questão_27_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 27-lista 01");

            Console.WriteLine("Número de termos:");
            int termos = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1;i<=termos;i++)
            {
                int cubo = Convert.ToInt32(Math.Pow(i,3));
                Console.WriteLine("Número " + i + " e o cubo de " + i + " é: " + cubo + ".");
            }

            Console.ReadLine();
        }
    }
}
