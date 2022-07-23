using System;

namespace Questão_02_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 02-Lista 01");

            Console.WriteLine("Digite o Raio da Esfera (em centímetros) na qual a área será calculada:");
            double raio = Convert.ToDouble(Console.ReadLine());

            double volume = 4 * Math.PI * Math.Pow(raio, 3) / 3;
            Console.WriteLine("O Volume da Esfera de Raio " + raio + "cm é de " + volume + "cm");

            Console.ReadLine();
        }
    }
}
