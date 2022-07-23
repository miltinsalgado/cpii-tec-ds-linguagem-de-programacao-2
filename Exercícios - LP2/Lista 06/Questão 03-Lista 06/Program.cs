using System;

namespace Questão_03_Lista_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 03-Lista 06");

            Produto produto = new Produto(1003, 10, "trena", 15.99);
            Produto produto2 = new Produto(2750, 20, "serra elétrica", 49.99);
            Produto produto3 = new Produto(564, 50, "tinta azul", 21.99);

            Console.WriteLine(produto.Show_Prod());
            Console.WriteLine(produto2.Show_Prod());
            Console.WriteLine(produto3.Show_Prod());

            Console.ReadLine();
        }
    }
}
