using System;

namespace Questão_18_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 18-Lista 01");

            Console.WriteLine("Entre com uma temperatura em Graus Centígrados (°C):\t");
            double centigrados = Convert.ToDouble(Console.ReadLine());

            if (centigrados < 0)
                Console.WriteLine("Está congelando!");

            else if ((centigrados >= 0) && (centigrados <= 10))
                Console.WriteLine("Está muito frio!");

            else if ((centigrados > 10) && (centigrados <= 20))
                Console.WriteLine("Está frio!");

            else if ((centigrados > 20) && (centigrados <= 30))
                Console.WriteLine("Está normal!");

            else if ((centigrados > 30) && (centigrados <= 40))          
                Console.WriteLine("Está quente!");

            else if (centigrados > 40)
                Console.WriteLine("Está muito quente!");

            Console.ReadLine();
        }
    }
}
