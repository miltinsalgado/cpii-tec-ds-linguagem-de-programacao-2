
namespace Questão_01_Lista_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto_entrada = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.NumericUpDown();
            this.label_fatorial = new System.Windows.Forms.Label();
            this.label_par = new System.Windows.Forms.Label();
            this.label_primo = new System.Windows.Forms.Label();
            this.valor_fatorial = new System.Windows.Forms.TextBox();
            this.check_par = new System.Windows.Forms.TextBox();
            this.check_primo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listagem = new System.Windows.Forms.TextBox();
            this.lista_num_primo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entrada)).BeginInit();
            this.SuspendLayout();
            // 
            // texto_entrada
            // 
            this.texto_entrada.AutoSize = true;
            this.texto_entrada.Location = new System.Drawing.Point(12, 28);
            this.texto_entrada.Name = "texto_entrada";
            this.texto_entrada.Size = new System.Drawing.Size(119, 20);
            this.texto_entrada.TabIndex = 0;
            this.texto_entrada.Text = "Valor de Entrada";
            // 
            // entrada
            // 
            this.entrada.Location = new System.Drawing.Point(137, 26);
            this.entrada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(126, 27);
            this.entrada.TabIndex = 1;
            this.entrada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_fatorial
            // 
            this.label_fatorial.AutoSize = true;
            this.label_fatorial.Location = new System.Drawing.Point(30, 106);
            this.label_fatorial.Name = "label_fatorial";
            this.label_fatorial.Size = new System.Drawing.Size(62, 20);
            this.label_fatorial.TabIndex = 2;
            this.label_fatorial.Text = "Fatorial ";
            // 
            // label_par
            // 
            this.label_par.AutoSize = true;
            this.label_par.Location = new System.Drawing.Point(30, 139);
            this.label_par.Name = "label_par";
            this.label_par.Size = new System.Drawing.Size(50, 20);
            this.label_par.TabIndex = 3;
            this.label_par.Text = "É par?";
            // 
            // label_primo
            // 
            this.label_primo.AutoSize = true;
            this.label_primo.Location = new System.Drawing.Point(30, 172);
            this.label_primo.Name = "label_primo";
            this.label_primo.Size = new System.Drawing.Size(68, 20);
            this.label_primo.TabIndex = 4;
            this.label_primo.Text = "É primo?";
            // 
            // valor_fatorial
            // 
            this.valor_fatorial.Location = new System.Drawing.Point(173, 106);
            this.valor_fatorial.Name = "valor_fatorial";
            this.valor_fatorial.ReadOnly = true;
            this.valor_fatorial.Size = new System.Drawing.Size(73, 27);
            this.valor_fatorial.TabIndex = 5;
            // 
            // check_par
            // 
            this.check_par.Location = new System.Drawing.Point(173, 139);
            this.check_par.Name = "check_par";
            this.check_par.ReadOnly = true;
            this.check_par.Size = new System.Drawing.Size(73, 27);
            this.check_par.TabIndex = 6;
            // 
            // check_primo
            // 
            this.check_primo.Location = new System.Drawing.Point(173, 172);
            this.check_primo.Name = "check_primo";
            this.check_primo.ReadOnly = true;
            this.check_primo.Size = new System.Drawing.Size(73, 27);
            this.check_primo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Realizar Análise";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listagem
            // 
            this.listagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listagem.Location = new System.Drawing.Point(12, 237);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(251, 27);
            this.listagem.TabIndex = 9;
            // 
            // lista_num_primo
            // 
            this.lista_num_primo.AutoSize = true;
            this.lista_num_primo.Location = new System.Drawing.Point(26, 214);
            this.lista_num_primo.Name = "lista_num_primo";
            this.lista_num_primo.Size = new System.Drawing.Size(220, 20);
            this.lista_num_primo.TabIndex = 10;
            this.lista_num_primo.Text = "Todos os primos menores que 0";
            this.lista_num_primo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 299);
            this.Controls.Add(this.lista_num_primo);
            this.Controls.Add(this.listagem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_primo);
            this.Controls.Add(this.check_par);
            this.Controls.Add(this.valor_fatorial);
            this.Controls.Add(this.label_primo);
            this.Controls.Add(this.label_par);
            this.Controls.Add(this.label_fatorial);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.texto_entrada);
            this.Name = "Form1";
            this.Text = "Questão 01-Lista 10";
            ((System.ComponentModel.ISupportInitialize)(this.entrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto_entrada;
        private System.Windows.Forms.NumericUpDown entrada;
        private System.Windows.Forms.Label label_fatorial;
        private System.Windows.Forms.Label label_par;
        private System.Windows.Forms.Label label_primo;
        private System.Windows.Forms.TextBox valor_fatorial;
        private System.Windows.Forms.TextBox check_par;
        private System.Windows.Forms.TextBox check_primo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox listagem;
        private System.Windows.Forms.Label lista_num_primo;
    }
}

