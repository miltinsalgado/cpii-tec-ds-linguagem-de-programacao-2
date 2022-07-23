using System;

namespace Questão_02_Lista_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 02-Lista 11");

            Carro Carro_1 = new Carro(50, 0, 10, "Pedro");
            Carro Carro_2 = new Carro(10, 0, 20, "Maria");

            Console.WriteLine("\nCORRIDA");
            Console.WriteLine("Dados do primeiro carro:");
            Console.WriteLine("Nome do(a) piloto(a): " + Carro_1.Piloto);
            Console.WriteLine("Posição inicial do carro: " + Carro_1.S + " m");
            Console.WriteLine("Velocidade inicial do carro: " + Carro_1.V + " m/s");
            Console.WriteLine("Aceleração constante do carro: " + Carro_1.GetAceleração() + " m/s²");
            Console.WriteLine("=======================================");
            Console.WriteLine("Dados do segundo carro:");
            Console.WriteLine("Nome do(a) piloto(a): " + Carro_2.Piloto);
            Console.WriteLine("Posição inicial do carro: " + Carro_2.S + " m");
            Console.WriteLine("Velocidade inicial do carro: " + Carro_2.V + " m/s");
            Console.WriteLine("Aceleração constante do carro: " + Carro_2.GetAceleração() + " m/s²");

            int cronômetro = 0;
            do
            {
                cronômetro++;
                Carro_1.Mover(Convert.ToDouble(cronômetro));
                Carro_2.Mover(Convert.ToDouble(cronômetro));
            } while (Carro_1.S >= Carro_2.S);

            Console.WriteLine("\n" + Carro_2.Piloto + " ultrapassou " + Carro_1.Piloto + " no " + cronômetro + "° segundo.");

            Console.ReadLine();
        }
    }
}
