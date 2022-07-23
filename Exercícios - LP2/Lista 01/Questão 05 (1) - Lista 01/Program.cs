using System;

namespace Questão_05__1____Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 05 (1) - Lista 01");

            Console.WriteLine("Entre com os minutos a serem convertidas em horas e minutos: ");
            
            int minutos = Convert.ToInt32(Console.ReadLine());
            int horas = minutos / 60;

            Console.WriteLine("O total de horas e minurtos  de " + horas + " horas e " + minutos % 60 + " minutos.");

            Console.ReadLine();
        }
    }
}
