using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_03_Lista_06
{
    class Produto
    {
        private int num_ident = 1, qtd_itens = 0;
        public string nome_prod = "";
        private double preco_prod = 0;

        public Produto (int num, int qtd, string nome, double preco)
        {
            Set_Num(num);
            Set_Qtd(qtd);
            nome_prod = nome;
            Set_Preco(preco);
        }

        public void Set_Num(int n)
        {
            if (n >= 1 && n <= 9999)
                num_ident = n;
        }

        public int Get_Num()
        {
            return num_ident;
        }

        public void Set_Qtd(int q)
        {
            if (q > 0)
                qtd_itens = q;
        }

        public int Get_Qtd()
        {
            return qtd_itens;
        }

        public void Set_Preco(double p)
        {
            if (p > 0)
                preco_prod = p;
        }

        public double Get_Preco()
        {
            return preco_prod;
        }

        public string Show_Prod()
        {
            return "\nINFORMAÇÕES DO PRODUTO \nNúmero de Identificação: " + num_ident + " \nQuantidade do produto: " + qtd_itens + "\nNome do produto: " + nome_prod + "\nPreço do Produto: " + preco_prod.ToString("C");
        }
    }
}
