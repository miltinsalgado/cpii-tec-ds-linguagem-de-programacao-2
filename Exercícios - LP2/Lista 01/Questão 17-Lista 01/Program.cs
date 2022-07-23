using System;

namespace Questão_17_Lista_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 17-Lista 01");

            Console.WriteLine("Entre com a matrícula do estudante:\t");
            string matricula = Console.ReadLine();

            Console.WriteLine("Entre com o nome do estudante:\t");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com a nota de português:\t");
            double nota_portugues = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEntre com a nota de história:\t");
            double nota_historia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEntre com a nota de filosofia:\t");
            double nota_filosofia = Convert.ToDouble(Console.ReadLine());

            double nota_total = nota_portugues + nota_historia + nota_filosofia;
            double rendimento = (nota_total / 300) * 100;

            Console.WriteLine("\nMatrícula:\t" + matricula + "\nNome:\t" + nome + "\nNota em português:\t " + nota_portugues + "\nNota em história:\t"+ nota_historia + "\nNota em filosofia:\t" + nota_filosofia + "\nNota total:\t" + nota_total + "\nRendimento(%):\t" + rendimento);

            Console.ReadLine();
        }
    }
}
