using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_04_Lista_05
{
    class Data
    {
        public int dia;
        public int mes;
        public int ano;

        public string nome_mes;

        public string Descrever()
        {
            return "Este objeto data refere-se à data de " + Convert.ToString(dia) + " do mês de " + nome_mes + " do ano de " + Convert.ToString(ano) + ".";
        }

        public bool EhBissexto()
        {
            if ((ano % 400 == 0) || (ano % 100 != 0 && ano % 4 == 0))
                return true;
            else
                return false;
        }
    }
}
