using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_01_Lista_06
{
    class Data
    {
        private int dia, mes, ano;

        public Data(int d, int m, int a)
        {
            SetDia(d);
            SetMes(m);
            SetAno(a);
        }

        public void SetDia(int d)
        {
            if (d >= 1 && d <= 31)
                dia = d;
        }

        public int GetDia()
        {
            return dia;
        }

        public void SetMes(int m)
        {
            if (m >= 1 && m <= 12)
                mes = m;
        }

        public int GetMes()
        {
            return mes;
        }

        public void SetAno(int a)
        {
            if (a >= 1)
                ano = a;
        }

        public int GetAno()
        {
            return ano;
        }
        
        public string ExibirData()
        {
            string dia_s = Convert.ToString(dia);
            string mes_s = Convert.ToString(mes);
            string ano_s = Convert.ToString(ano);

            if (dia_s.Length == 1)
                dia_s = "0" + dia_s;
            if (mes_s.Length == 1)
                mes_s = "0" + mes_s;

            return dia_s + "/" + mes_s + "/" + ano_s;
        }
    }
}
