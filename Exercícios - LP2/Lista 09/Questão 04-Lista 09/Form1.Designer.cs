
namespace Questão_04_Lista_09
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
            this.name = new System.Windows.Forms.TextBox();
            this.vogais_i = new System.Windows.Forms.TextBox();
            this.vogais_e = new System.Windows.Forms.TextBox();
            this.vogais_o = new System.Windows.Forms.TextBox();
            this.vogais_u = new System.Windows.Forms.TextBox();
            this.vogais_a = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.O = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.Label();
            this.botao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(167, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 27);
            this.name.TabIndex = 0;
            // 
            // vogais_i
            // 
            this.vogais_i.Location = new System.Drawing.Point(231, 106);
            this.vogais_i.Name = "vogais_i";
            this.vogais_i.ReadOnly = true;
            this.vogais_i.Size = new System.Drawing.Size(34, 27);
            this.vogais_i.TabIndex = 1;
            // 
            // vogais_e
            // 
            this.vogais_e.Location = new System.Drawing.Point(168, 106);
            this.vogais_e.Name = "vogais_e";
            this.vogais_e.ReadOnly = true;
            this.vogais_e.Size = new System.Drawing.Size(34, 27);
            this.vogais_e.TabIndex = 2;
            // 
            // vogais_o
            // 
            this.vogais_o.Location = new System.Drawing.Point(295, 106);
            this.vogais_o.Name = "vogais_o";
            this.vogais_o.ReadOnly = true;
            this.vogais_o.Size = new System.Drawing.Size(34, 27);
            this.vogais_o.TabIndex = 3;
            // 
            // vogais_u
            // 
            this.vogais_u.Location = new System.Drawing.Point(358, 106);
            this.vogais_u.Name = "vogais_u";
            this.vogais_u.ReadOnly = true;
            this.vogais_u.Size = new System.Drawing.Size(34, 27);
            this.vogais_u.TabIndex = 4;
            // 
            // vogais_a
            // 
            this.vogais_a.Location = new System.Drawing.Point(105, 106);
            this.vogais_a.Name = "vogais_a";
            this.vogais_a.ReadOnly = true;
            this.vogais_a.Size = new System.Drawing.Size(34, 27);
            this.vogais_a.TabIndex = 5;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(152, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(140, 20);
            this.titulo.TabIndex = 6;
            this.titulo.Text = "Contador de Vogais";
            // 
            // entrada
            // 
            this.entrada.AutoSize = true;
            this.entrada.Location = new System.Drawing.Point(15, 52);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(143, 20);
            this.entrada.TabIndex = 7;
            this.entrada.Text = "Entre com um nome";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(82, 109);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(17, 20);
            this.A.TabIndex = 8;
            this.A.Text = "a";
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(145, 109);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(17, 20);
            this.E.TabIndex = 9;
            this.E.Text = "e";
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Location = new System.Drawing.Point(212, 109);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(13, 20);
            this.I.TabIndex = 10;
            this.I.Text = "i";
            // 
            // O
            // 
            this.O.AutoSize = true;
            this.O.Location = new System.Drawing.Point(271, 109);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(18, 20);
            this.O.TabIndex = 11;
            this.O.Text = "o";
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.Location = new System.Drawing.Point(335, 109);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(17, 20);
            this.U.TabIndex = 12;
            this.U.Text = "u";
            // 
            // botao
            // 
            this.botao.Location = new System.Drawing.Point(298, 34);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(166, 57);
            this.botao.TabIndex = 13;
            this.botao.Text = "Verificar Vogais";
            this.botao.UseVisualStyleBackColor = true;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 143);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.U);
            this.Controls.Add(this.O);
            this.Controls.Add(this.I);
            this.Controls.Add(this.E);
            this.Controls.Add(this.A);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.vogais_a);
            this.Controls.Add(this.vogais_u);
            this.Controls.Add(this.vogais_o);
            this.Controls.Add(this.vogais_e);
            this.Controls.Add(this.vogais_i);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox vogais_i;
        private System.Windows.Forms.TextBox vogais_e;
        private System.Windows.Forms.TextBox vogais_o;
        private System.Windows.Forms.TextBox vogais_u;
        private System.Windows.Forms.TextBox vogais_a;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label entrada;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label I;
        private System.Windows.Forms.Label O;
        private System.Windows.Forms.Label U;
        private System.Windows.Forms.Button botao;
    }
}

