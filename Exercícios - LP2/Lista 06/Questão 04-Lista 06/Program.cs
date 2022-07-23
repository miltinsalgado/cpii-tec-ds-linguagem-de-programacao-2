using System;

namespace Questão_04_Lista_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 04-Lista 06");

            Cifra cifra_decifra = new Cifra();

            Console.WriteLine("Digite uma mensagem para que seja realizada a criptografia: ");
            string mens_cripto = Console.ReadLine();
            Console.WriteLine("Mensagem [" + mens_cripto + "] criptografada = [" + cifra_decifra.Criptografar(mens_cripto) + "]");

            Console.WriteLine("Digite uma mensagem para que seja realizada a descriptografia: ");
            string mens_descripto = Console.ReadLine();
            Console.WriteLine("Mensagem [" + mens_descripto + "] descriptografada = [" + cifra_decifra.Descriptografar(mens_descripto) + "]");

            Console.ReadLine();
        }
    }
}
