using System;

namespace Questão_01_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 01-Lista 01");
            Console.WriteLine("Digite a temperatura em graus Celsius (°C) a ser convertida para Graus Fahrenheit (°F):");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (1.8 * celsius) + 32;
            Console.WriteLine("A Temperatura em Graus Celsius (°C) digitada (" + celsius + "°C) equivale à (" + fahrenheit + "°F) Graus Fahrenheit ");

            Console.ReadLine();
        }
    }
}
