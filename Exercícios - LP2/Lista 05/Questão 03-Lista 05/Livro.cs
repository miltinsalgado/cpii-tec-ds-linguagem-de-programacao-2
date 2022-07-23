using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_03_Lista_05
{
    class Livro
    {
        public string Titulo;
        public string Autor;
        public double Preco;
        public string Descrever()
        {
            return "O livro " + Titulo + " foi escrito por " + Autor + " e custa " + Convert.ToString(Preco) + " reais.";
        }
    }
}