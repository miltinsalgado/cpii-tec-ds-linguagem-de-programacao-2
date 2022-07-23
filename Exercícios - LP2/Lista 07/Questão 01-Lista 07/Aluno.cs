using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_01_Lista_07
{
    class Aluno
    {
        public string Nome;
        private int Idade;
        private int Matricula;
        static public int Quantidade;

        public Aluno(string nome, int idade, int matricula)
        {
            Nome = nome;
            SetIdade(idade);
            SetMatricula(matricula);
            Quantidade++;
        }

        public bool SetIdade(int idade)
        {
            if (idade >= 3 && idade <= 21)
            {
                Idade = idade;
                return true;
            }
            else
                return false;
        }

        public int GetIdade()
        {
            return Idade;
        }

        public bool SetMatricula(int matricula)
        {
            if (matricula > 100000 && matricula < 190000)
            {
                Matricula = matricula;
                return true;
            }
            else
                return false;
        }

        public int GetMatricula()
        {
            return Matricula;
        }
    }
}
