using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_02_Lista_06
{
    class Funcionario
    {
        public string nome = "", sobrenome = "";
        private double salario_mensal = 0;

        public Funcionario (string n, string s, double s_m)
        {
            nome = n;
            sobrenome = s;
            Set_Salario(s_m);
        }

        public void Set_Salario(double salario_set)
        {
            if (salario_set >= 0 && salario_set < 20000)
                salario_mensal = salario_set;
        }

        public double Get_Salario()
        {
            return salario_mensal;
        }

        public string Show_Funcionario()
        {
            return "Funcionário " + nome + " " + sobrenome + " - Salário: " + salario_mensal.ToString("C");
        }
    }
}
