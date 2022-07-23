using System;

namespace Questão_03_Lista_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 03-Lista 05");

            Livro livro = new Livro();

            Console.WriteLine("Digite o título do livro: ");
            livro.Titulo = Console.ReadLine();

            Console.WriteLine("Digite o autor do livro " + livro.Titulo + ": ");
            livro.Autor = Console.ReadLine();

            Console.WriteLine("Digite o preço do livro " + livro.Titulo + ": ");
            livro.Preco = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(livro.Descrever());

            Console.ReadLine();
        }
    }
}
