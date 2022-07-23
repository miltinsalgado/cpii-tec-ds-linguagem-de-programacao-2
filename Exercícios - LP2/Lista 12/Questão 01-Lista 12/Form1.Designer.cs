
namespace Questão_01_Lista_12
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
            this.adição = new System.Windows.Forms.RadioButton();
            this.subtração = new System.Windows.Forms.RadioButton();
            this.divisão = new System.Windows.Forms.RadioButton();
            this.multiplicação = new System.Windows.Forms.RadioButton();
            this.num_1 = new System.Windows.Forms.NumericUpDown();
            this.num_2 = new System.Windows.Forms.NumericUpDown();
            this.resultado = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // adição
            // 
            this.adição.AutoSize = true;
            this.adição.Location = new System.Drawing.Point(12, 45);
            this.adição.Name = "adição";
            this.adição.Size = new System.Drawing.Size(40, 24);
            this.adição.TabIndex = 1;
            this.adição.TabStop = true;
            this.adição.Text = "+";
            this.adição.UseVisualStyleBackColor = true;
            // 
            // subtração
            // 
            this.subtração.AutoSize = true;
            this.subtração.Location = new System.Drawing.Point(58, 45);
            this.subtração.Name = "subtração";
            this.subtração.Size = new System.Drawing.Size(36, 24);
            this.subtração.TabIndex = 2;
            this.subtração.TabStop = true;
            this.subtração.Text = "-";
            this.subtração.UseVisualStyleBackColor = true;
            // 
            // divisão
            // 
            this.divisão.AutoSize = true;
            this.divisão.Location = new System.Drawing.Point(100, 45);
            this.divisão.Name = "divisão";
            this.divisão.Size = new System.Drawing.Size(36, 24);
            this.divisão.TabIndex = 3;
            this.divisão.TabStop = true;
            this.divisão.Text = "/";
            this.divisão.UseVisualStyleBackColor = true;
            // 
            // multiplicação
            // 
            this.multiplicação.AutoSize = true;
            this.multiplicação.Location = new System.Drawing.Point(142, 45);
            this.multiplicação.Name = "multiplicação";
            this.multiplicação.Size = new System.Drawing.Size(36, 24);
            this.multiplicação.TabIndex = 4;
            this.multiplicação.TabStop = true;
            this.multiplicação.Text = "*";
            this.multiplicação.UseVisualStyleBackColor = true;
            // 
            // num_1
            // 
            this.num_1.Location = new System.Drawing.Point(12, 12);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(166, 27);
            this.num_1.TabIndex = 0;
            // 
            // num_2
            // 
            this.num_2.Location = new System.Drawing.Point(12, 75);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(166, 27);
            this.num_2.TabIndex = 5;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(12, 143);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(166, 27);
            this.resultado.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 178);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.multiplicação);
            this.Controls.Add(this.divisão);
            this.Controls.Add(this.subtração);
            this.Controls.Add(this.adição);
            this.Controls.Add(this.num_1);
            this.Name = "Form1";
            this.Text = "Questão 01-Lista 12";
            ((System.ComponentModel.ISupportInitialize)(this.num_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton adição;
        private System.Windows.Forms.RadioButton subtração;
        private System.Windows.Forms.RadioButton divisão;
        private System.Windows.Forms.RadioButton multiplicação;
        private System.Windows.Forms.NumericUpDown num_1;
        private System.Windows.Forms.NumericUpDown num_2;
        private System.Windows.Forms.NumericUpDown resultado;
        private System.Windows.Forms.Button button1;
    }
}

