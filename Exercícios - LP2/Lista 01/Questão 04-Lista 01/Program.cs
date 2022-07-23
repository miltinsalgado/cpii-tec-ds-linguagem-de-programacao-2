using System;

namespace Questão_04_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 04-Lista 01");

            Console.WriteLine("Digite a velocidade em km/h (Quilômetros por hora) que será convertida em milhas/h (Milhas por hora)");
            double km_h = Convert.ToDouble(Console.ReadLine());

            double milhas_h = km_h * 0.62137;
            Console.WriteLine("A velocidade digitada em km/h (" + km_h + ") equivale (em milhas/h) à " + milhas_h + ".");

            Console.ReadLine();
        }
    }
}
