
namespace Questão_02_Lista_12
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Matricula = new System.Windows.Forms.NumericUpDown();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Curso = new System.Windows.Forms.TextBox();
            this.Mensalidade = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.desc_10 = new System.Windows.Forms.RadioButton();
            this.desc_7 = new System.Windows.Forms.RadioButton();
            this.desc_5 = new System.Windows.Forms.RadioButton();
            this.desc_3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Matricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mensalidade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mensalidade (R$)";
            // 
            // Matricula
            // 
            this.Matricula.Location = new System.Drawing.Point(89, 12);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(193, 27);
            this.Matricula.TabIndex = 4;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(89, 45);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(193, 27);
            this.Nome.TabIndex = 5;
            // 
            // Curso
            // 
            this.Curso.Location = new System.Drawing.Point(89, 78);
            this.Curso.Name = "Curso";
            this.Curso.Size = new System.Drawing.Size(193, 27);
            this.Curso.TabIndex = 6;
            // 
            // Mensalidade
            // 
            this.Mensalidade.DecimalPlaces = 2;
            this.Mensalidade.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Mensalidade.Location = new System.Drawing.Point(143, 111);
            this.Mensalidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Mensalidade.Name = "Mensalidade";
            this.Mensalidade.Size = new System.Drawing.Size(139, 27);
            this.Mensalidade.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.desc_10);
            this.groupBox1.Controls.Add(this.desc_7);
            this.groupBox1.Controls.Add(this.desc_5);
            this.groupBox1.Controls.Add(this.desc_3);
            this.groupBox1.Location = new System.Drawing.Point(12, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desconto";
            // 
            // desc_10
            // 
            this.desc_10.AutoSize = true;
            this.desc_10.Location = new System.Drawing.Point(206, 26);
            this.desc_10.Name = "desc_10";
            this.desc_10.Size = new System.Drawing.Size(58, 24);
            this.desc_10.TabIndex = 3;
            this.desc_10.TabStop = true;
            this.desc_10.Text = "10%";
            this.desc_10.UseVisualStyleBackColor = true;
            // 
            // desc_7
            // 
            this.desc_7.AutoSize = true;
            this.desc_7.Location = new System.Drawing.Point(141, 26);
            this.desc_7.Name = "desc_7";
            this.desc_7.Size = new System.Drawing.Size(50, 24);
            this.desc_7.TabIndex = 2;
            this.desc_7.TabStop = true;
            this.desc_7.Text = "7%";
            this.desc_7.UseVisualStyleBackColor = true;
            // 
            // desc_5
            // 
            this.desc_5.AutoSize = true;
            this.desc_5.Location = new System.Drawing.Point(75, 26);
            this.desc_5.Name = "desc_5";
            this.desc_5.Size = new System.Drawing.Size(50, 24);
            this.desc_5.TabIndex = 1;
            this.desc_5.TabStop = true;
            this.desc_5.Text = "5%";
            this.desc_5.UseVisualStyleBackColor = true;
            // 
            // desc_3
            // 
            this.desc_3.AutoSize = true;
            this.desc_3.Location = new System.Drawing.Point(6, 26);
            this.desc_3.Name = "desc_3";
            this.desc_3.Size = new System.Drawing.Size(50, 24);
            this.desc_3.TabIndex = 0;
            this.desc_3.TabStop = true;
            this.desc_3.Text = "3%";
            this.desc_3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar Aluno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 297);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 104);
            this.listBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpar Registros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 483);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Mensalidade);
            this.Controls.Add(this.Curso);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Questão 02-Lista 12";
            ((System.ComponentModel.ISupportInitialize)(this.Matricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mensalidade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Matricula;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Curso;
        private System.Windows.Forms.NumericUpDown Mensalidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton desc_10;
        private System.Windows.Forms.RadioButton desc_7;
        private System.Windows.Forms.RadioButton desc_5;
        private System.Windows.Forms.RadioButton desc_3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

