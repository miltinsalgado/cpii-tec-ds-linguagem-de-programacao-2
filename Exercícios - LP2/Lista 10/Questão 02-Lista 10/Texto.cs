using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_02_Lista_10
{
    class Texto
    {
        public static string Inverter(string str)
        {
            string str_aux = "";
            for (int i = str.Length - 1; i >= 0; i--)
                str_aux += str[i];

            return str_aux;
        }

        public static bool EhPalindromo(string str)
        {
            if (Inverter(str) == str)
                return true;
            else
                return false;
        }

        public static int ContarVogais(string str)
        {
            string str_aux = str.ToUpper();
            int count_vogais = 0;
            for (int i = 0; i < str_aux.Length; i++)
                if (str_aux[i] == 'A' || str_aux[i] == 'Á' || str_aux[i] == 'E' || str_aux[i] == 'I' || str_aux[i] == 'O' || str_aux[i] == 'U')
                    count_vogais++;

            return count_vogais;
        }
    }
}
