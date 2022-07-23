using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questões_01_02_Teste_02
{
    public partial class Form1 : Form
    {
        // Nome: Milton Salgado Leandro - Turma: IN-210 - Professor: João Lagôas

        public Form1()
        {
            InitializeComponent();
        }

        // Questão 02 - Letra a) - Declaração de variáveis para receberem os valores do formulário
        // e realizar as instâncias de Ponto e Círculo.
        private void button1_Click(object sender, EventArgs e)
        {
            decimal raio_1 = numRaio1.Value;
            decimal X_1 = numX1.Value;
            decimal Y_1 = numY1.Value;
            Ponto ponto_1 = new Ponto(X_1, Y_1);
            Círculo circ_1 = new Círculo(ponto_1, raio_1);

            decimal raio_2 = numRaio2.Value;
            decimal X_2 = numX2.Value;
            decimal Y_2 = numY2.Value;
            Ponto ponto_2 = new Ponto(X_2, Y_2);
            Círculo circ_2 = new Círculo(ponto_2, raio_2);

            // Declaração de variáveis booleanas para receber os valores do método SetRaio de acordo com cada um dos raios.
            bool verifica_raio_1 = circ_1.SetRaio(raio_1);
            bool verifica_raio_2 = circ_2.SetRaio(raio_2);

            // Dependendo dos valores das variáveis booleanas, será mostrado ou não uma mensagem de erro através do método
            // Mostrar_Mensagem, e caso mostrada, será chamado o método Ajustar_Valores que zera o valor colocado nos raios.
            // Caso não seja mostrada, o código segue para a chamada dos métodos Comparar_Círculos e Verificar_Interceptação.
            if (Mostrar_Mensagem(verifica_raio_1, verifica_raio_2) == true)
                Ajustar_Valores();
            else
            {
                Comparar_Círculos(circ_1, circ_2);
                Verificar_Interceptação(circ_1, circ_2);
            }
        }

        // Método Mostrar_Mensagem que apresenta uma mensagem de erro caso um dos valores de raio seja inválido,
        // retornando true quando isto ocorre.
        private bool Mostrar_Mensagem(bool V_r1, bool V_r2)
        {
            if (V_r1 == false || V_r2 == false)
            {
                MessageBox.Show("Os raios dos círculos devem ser positivos! \nPor favor, selecione um valor positivo para os raios no formulário. \nPara continuar, clique em OK", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                return false;
        }

        // Método Ajustar_Valores que zera os valores de área e perimetro
        // e também modifica os textos da labMaior e da txtBoxInterc.
        private void Ajustar_Valores()
        {
            numArea.Value = 0;
            numPeri.Value = 0;
            labMaior.Text = "Clique no botão {Analisar Círculos} para verificar qual dos círculos é o maior";
            txtBoxInterc.Text = "Clique no botão {Analisar Círculos} para verificar se os círculos se interceptam ou não";
        }

        // Método Comparar_Círculos compara o raio dos círculos, e utiliza os métodos Calcular_Área e Calcular_Perímetro
        // (presentes na classe Circulo.cs, criada anteriormente) para calcular os respectivos valores
        // do maior círculo e por fim apresentá-los no formulário.
        private void Comparar_Círculos(Círculo cir1, Círculo cir2)
        {
            decimal r1 = cir1.GetRaio();
            decimal r2 = cir2.GetRaio();
            if (r1 > r2)
            {
                labMaior.Text = "O maior círculo é o primeiro";
                numArea.Value = cir1.CalcularÁrea(r1);
                numPeri.Value = cir1.CalcularPerímetro(r1);
            }    
            else if (r2 > r1)
            {
                labMaior.Text = "O maior círculo é o segundo";
                numArea.Value = cir2.CalcularÁrea(r2);
                numPeri.Value = cir2.CalcularPerímetro(r2);
            }
            else
            {
                labMaior.Text = "Os círculos são congruentes";
                numArea.Value = cir1.CalcularÁrea(r1);
                numPeri.Value = cir2.CalcularPerímetro(r2);
            }    
        }

        // Método Verificar_Interceptação que utiliza o retorno do método (presentes na classe Circulo.cs, criada anteriormente),
        // e dependendo do resultado, modifica o texto da txtBoxInterc no formulário.
        private void Verificar_Interceptação(Círculo cir1, Círculo cir2)
        {
            bool intercepta = Círculo.Intercepta(cir1, cir2);
            if (intercepta == true)
                txtBoxInterc.Text = "Os círculos se interceptam";
            else
                txtBoxInterc.Text = "Os círculos não se interceptam";
        }
    }
}
