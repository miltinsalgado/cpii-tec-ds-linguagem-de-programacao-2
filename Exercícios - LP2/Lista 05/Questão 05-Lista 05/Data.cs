using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_05_Lista_05
{
    class Data
    {
        public int dia;
        public int mes;
        public int ano;

        public string nome_mes = "";

        public string Descrever()
        {
            switch (mes)
            {
                case 1:
                    nome_mes = "janeiro";
                    break;
                case 2:
                    nome_mes = "fevereiro";
                    break;
                case 3:
                    nome_mes = "março";
                    break;
                case 4:
                    nome_mes = "abril";
                    break;
                case 5:
                    nome_mes = "maio";
                    break;
                case 6:
                    nome_mes = "junho";
                    break;
                case 7:
                    nome_mes = "julho";
                    break;
                case 8:
                    nome_mes = "agosto";
                    break;
                case 9:
                    nome_mes = "setembro";
                    break;
                case 10:
                    nome_mes = "outubro";
                    break;
                case 11:
                    nome_mes = "novembro";
                    break;
                case 12:
                    nome_mes = "dezembro";
                    break;
            }
            return "Este objeto data refere-se à data de " + Convert.ToString(dia) + " do mês de " + nome_mes + " do ano de " + Convert.ToString(ano) + ".";
        }

        public bool EhBissexto()
        {
            if ((ano % 400 == 0) || (ano % 100 != 0 && ano % 4 == 0))
                return true;
            else
                return false;
        }

        public int CompararDatas(Data data)
        {
            if (data.ano > ano)
                return 1;
            else if (data.mes > mes && data.ano == ano)
                return 1;
            else if (data.dia > dia && data.mes == mes && data.ano == ano)
                return 1;
            else if ((data.dia == dia && data.mes == mes && data.ano == ano))
                return 2;
            else 
                return 0;
        }
    }
}