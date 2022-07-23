using System;

namespace Questão_03_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 03-Lista 01");

            Console.WriteLine("Digite a Altura do Retângulo (em centímetros) cujo perímetro será calculado: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite Largura do Retângulo (em centímetros) cujo perímetro será calculado: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            double perimetro = (altura * 2) + (largura * 2);
            Console.WriteLine("O Perímetro do Retângulo de Altura " + altura + "cm e Largura " + largura + "cm é de " + perimetro + "cm.");
            Console.ReadLine();
        }
    }
}
