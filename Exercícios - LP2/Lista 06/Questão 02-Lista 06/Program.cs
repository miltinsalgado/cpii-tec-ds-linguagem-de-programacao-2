using System;

namespace Questão_02_Lista_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 02-Lista 06");

            Funcionario func = new Funcionario("João", "Carlos", 15000);
            Funcionario func2 = new Funcionario("Jorge", "Aragão", 10000);

            Console.WriteLine(func.Show_Funcionario());
            Console.WriteLine(func2.Show_Funcionario());

            func.Set_Salario(func.Get_Salario() + func.Get_Salario() / 5);
            func2.Set_Salario(func2.Get_Salario() + func2.Get_Salario() / 5);
            Console.WriteLine("\nAumento de 20% aplicado nos salários!");

            Console.WriteLine(func.Show_Funcionario());
            Console.WriteLine(func2.Show_Funcionario());


            Console.ReadLine();
        }
    }
}
