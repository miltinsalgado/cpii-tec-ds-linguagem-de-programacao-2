
namespace Questão_02_Lista_10
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
            this.label_text = new System.Windows.Forms.Label();
            this.label_inv_text = new System.Windows.Forms.Label();
            this.label_vogal = new System.Windows.Forms.Label();
            this.label_palin = new System.Windows.Forms.Label();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.textBox_inv_text = new System.Windows.Forms.TextBox();
            this.textBox_palin = new System.Windows.Forms.TextBox();
            this.textBox_vogal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(12, 9);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(142, 20);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "Entre com um texto:";
            // 
            // label_inv_text
            // 
            this.label_inv_text.AutoSize = true;
            this.label_inv_text.Location = new System.Drawing.Point(12, 75);
            this.label_inv_text.Name = "label_inv_text";
            this.label_inv_text.Size = new System.Drawing.Size(116, 20);
            this.label_inv_text.TabIndex = 1;
            this.label_inv_text.Text = "Texto Invertitdo:";
            // 
            // label_vogal
            // 
            this.label_vogal.AutoSize = true;
            this.label_vogal.Location = new System.Drawing.Point(205, 134);
            this.label_vogal.Name = "label_vogal";
            this.label_vogal.Size = new System.Drawing.Size(156, 20);
            this.label_vogal.TabIndex = 2;
            this.label_vogal.Text = "Quantidade de Vogais";
            // 
            // label_palin
            // 
            this.label_palin.AutoSize = true;
            this.label_palin.Location = new System.Drawing.Point(12, 134);
            this.label_palin.Name = "label_palin";
            this.label_palin.Size = new System.Drawing.Size(106, 20);
            this.label_palin.TabIndex = 3;
            this.label_palin.Text = "É palíndromo?";
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(12, 32);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(430, 27);
            this.textBox_text.TabIndex = 4;
            // 
            // textBox_inv_text
            // 
            this.textBox_inv_text.Location = new System.Drawing.Point(12, 98);
            this.textBox_inv_text.Name = "textBox_inv_text";
            this.textBox_inv_text.Size = new System.Drawing.Size(430, 27);
            this.textBox_inv_text.TabIndex = 5;
            // 
            // textBox_palin
            // 
            this.textBox_palin.Location = new System.Drawing.Point(124, 131);
            this.textBox_palin.Name = "textBox_palin";
            this.textBox_palin.ReadOnly = true;
            this.textBox_palin.Size = new System.Drawing.Size(75, 27);
            this.textBox_palin.TabIndex = 6;
            // 
            // textBox_vogal
            // 
            this.textBox_vogal.Location = new System.Drawing.Point(367, 131);
            this.textBox_vogal.Name = "textBox_vogal";
            this.textBox_vogal.ReadOnly = true;
            this.textBox_vogal.Size = new System.Drawing.Size(75, 27);
            this.textBox_vogal.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_vogal);
            this.Controls.Add(this.textBox_palin);
            this.Controls.Add(this.textBox_inv_text);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.label_palin);
            this.Controls.Add(this.label_vogal);
            this.Controls.Add(this.label_inv_text);
            this.Controls.Add(this.label_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Label label_inv_text;
        private System.Windows.Forms.Label label_vogal;
        private System.Windows.Forms.Label label_palin;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.TextBox textBox_inv_text;
        private System.Windows.Forms.TextBox textBox_palin;
        private System.Windows.Forms.TextBox textBox_vogal;
        private System.Windows.Forms.Button button1;
    }
}

