using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_04_Lista_06
{
    class Cifra
    {
        public string Criptografar(string mensagem)
        {
            string nova_mensagem = "";
            for(int i = 0; i < mensagem.Length; i++)
            {
                int caracter = Convert.ToInt32(mensagem[i]);
                nova_mensagem += Convert.ToChar(caracter + 3);
            }
            return nova_mensagem;
        }

        public string Descriptografar(string mensagem)
        {
            string nova_mensagem = "";
            for (int i = 0; i < mensagem.Length; i++)
            {
                int caracter = Convert.ToInt32(mensagem[i]);
                nova_mensagem += Convert.ToChar(caracter - 3);
            }
            return nova_mensagem;
        }
    }
}
