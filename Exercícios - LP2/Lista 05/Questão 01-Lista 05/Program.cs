using System;

namespace Questão_01_Lista_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 01-Lista 05");

            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Digite a altura do retângulo: ");
            retangulo.Altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo: ");
            retangulo.Largura = Convert.ToInt32(Console.ReadLine());

            int perimetro = retangulo.CalcularPerimetro();
            int area = retangulo.CalcularArea();

            Console.WriteLine("O perímetro do retângulo vale {0}", perimetro);
            Console.WriteLine("A área do retângulo vale {0}", area);

            Console.ReadLine();
        }
    }
}
