using System;

namespace Questão_01_Lista_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno objAluno1 = new Aluno("Maria", 16, 154121);
            Aluno objAluno2 = new Aluno("Renata", 17, 184161);
            Aluno objAluno3 = new Aluno("Leonardo", 16, 185217);

            Console.WriteLine(objAluno1.GetIdade());
            Console.WriteLine(objAluno2.GetMatricula());
            Console.WriteLine(objAluno3.Nome);
            Console.WriteLine(Aluno.Quantidade);

            Console.ReadLine();
        }
    }
}
