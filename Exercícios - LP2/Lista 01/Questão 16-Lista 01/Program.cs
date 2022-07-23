using System;

namespace Questão_16_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 16-Lista 01");

            Console.WriteLine("Coeficiente Angular:\t");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coeficiente Linear:\t");
            double b = Convert.ToDouble(Console.ReadLine());

            double x = -b / a;

            Console.WriteLine("A raiz vale:\t" + x);

            Console.ReadLine();
        }
    }
}
