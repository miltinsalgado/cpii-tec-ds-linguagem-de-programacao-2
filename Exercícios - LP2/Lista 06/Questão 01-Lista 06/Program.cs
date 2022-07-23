using System;

namespace Questão_01_Lista_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 01-Lista 06");

            Data data = new Data(11, 04, 2021);
            

            Console.WriteLine("Dia do objeto data: " + data.GetDia());
            Console.WriteLine("Mês do objeto data: " + data.GetMes());
            Console.WriteLine("Ano do objeto data: " + data.GetAno());
            Console.WriteLine("\nData formatada: " + data.ExibirData());

            Console.ReadLine();
        }
    }
}
