using System;

namespace Questão_05_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 05-Lista 01");

            Console.WriteLine("Entre com as horas a serem convertidas em minutos: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com os minutos a serem somados com as horas digitadas anteriormente para o cálculo do total de minutos: ");
            int minutos = Convert.ToInt32(Console.ReadLine());

            int total = (horas * 60) + minutos;

            Console.WriteLine("O total de minutos é: " + total +  "minutos.");

            Console.ReadLine();

        }
    }
}
