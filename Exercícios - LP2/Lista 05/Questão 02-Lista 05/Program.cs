using System;

namespace Questão_02_Lista_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 02-Lista 05");
            Circulo circulo = new Circulo();

            Console.WriteLine("Digite o raio do círculo: ");
            circulo.Raio = Convert.ToInt32(Console.ReadLine());

            double perimetro = circulo.CalcularPerimetro();
            double area = circulo.CalcularArea();

            Console.WriteLine("O perímetro do círculo vale {0}", perimetro);
            Console.WriteLine("A área do círculo vale {0}", area);

            Console.ReadLine();
        }
    }
}
