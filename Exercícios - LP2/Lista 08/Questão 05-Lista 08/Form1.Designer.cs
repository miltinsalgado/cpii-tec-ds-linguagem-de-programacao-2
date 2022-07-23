
namespace Questão_05_Lista_08
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
            this.Title = new System.Windows.Forms.Label();
            this.Value_A = new System.Windows.Forms.TextBox();
            this.Value_B = new System.Windows.Forms.TextBox();
            this.Value_R = new System.Windows.Forms.TextBox();
            this.Value_I = new System.Windows.Forms.TextBox();
            this.Value_X = new System.Windows.Forms.TextBox();
            this.Calc_R = new System.Windows.Forms.Button();
            this.Calc_I = new System.Windows.Forms.Button();
            this.TCoef_Ang = new System.Windows.Forms.Label();
            this.TCoef_Lin = new System.Windows.Forms.Label();
            this.TFuncao = new System.Windows.Forms.Label();
            this.TFuncaoLinear = new System.Windows.Forms.Label();
            this.TX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(77, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(143, 28);
            this.Title.TabIndex = 0;
            this.Title.Text = "Função Linear";
            // 
            // Value_A
            // 
            this.Value_A.Location = new System.Drawing.Point(169, 53);
            this.Value_A.Name = "Value_A";
            this.Value_A.Size = new System.Drawing.Size(92, 27);
            this.Value_A.TabIndex = 1;
            this.Value_A.Text = "1";
            // 
            // Value_B
            // 
            this.Value_B.Location = new System.Drawing.Point(169, 86);
            this.Value_B.Name = "Value_B";
            this.Value_B.Size = new System.Drawing.Size(92, 27);
            this.Value_B.TabIndex = 2;
            this.Value_B.Text = "0";
            // 
            // Value_R
            // 
            this.Value_R.Location = new System.Drawing.Point(169, 172);
            this.Value_R.Name = "Value_R";
            this.Value_R.ReadOnly = true;
            this.Value_R.Size = new System.Drawing.Size(92, 27);
            this.Value_R.TabIndex = 3;
            this.Value_R.Text = "0";
            // 
            // Value_I
            // 
            this.Value_I.Location = new System.Drawing.Point(169, 205);
            this.Value_I.Name = "Value_I";
            this.Value_I.ReadOnly = true;
            this.Value_I.Size = new System.Drawing.Size(92, 27);
            this.Value_I.TabIndex = 4;
            this.Value_I.Text = "0";
            // 
            // Value_X
            // 
            this.Value_X.Location = new System.Drawing.Point(95, 263);
            this.Value_X.Name = "Value_X";
            this.Value_X.Size = new System.Drawing.Size(92, 27);
            this.Value_X.TabIndex = 5;
            this.Value_X.Text = "0";
            // 
            // Calc_R
            // 
            this.Calc_R.Location = new System.Drawing.Point(12, 170);
            this.Calc_R.Name = "Calc_R";
            this.Calc_R.Size = new System.Drawing.Size(134, 29);
            this.Calc_R.TabIndex = 6;
            this.Calc_R.Text = "Calcular Raiz";
            this.Calc_R.UseVisualStyleBackColor = true;
            this.Calc_R.Click += new System.EventHandler(this.Calc_R_Click);
            // 
            // Calc_I
            // 
            this.Calc_I.Location = new System.Drawing.Point(12, 203);
            this.Calc_I.Name = "Calc_I";
            this.Calc_I.Size = new System.Drawing.Size(134, 29);
            this.Calc_I.TabIndex = 7;
            this.Calc_I.Text = "Calcular Imagem";
            this.Calc_I.UseVisualStyleBackColor = true;
            this.Calc_I.Click += new System.EventHandler(this.Calc_I_Click);
            // 
            // TCoef_Ang
            // 
            this.TCoef_Ang.AutoSize = true;
            this.TCoef_Ang.Location = new System.Drawing.Point(12, 56);
            this.TCoef_Ang.Name = "TCoef_Ang";
            this.TCoef_Ang.Size = new System.Drawing.Size(140, 20);
            this.TCoef_Ang.TabIndex = 8;
            this.TCoef_Ang.Text = "Coeficiente Angular";
            // 
            // TCoef_Lin
            // 
            this.TCoef_Lin.AutoSize = true;
            this.TCoef_Lin.Location = new System.Drawing.Point(12, 89);
            this.TCoef_Lin.Name = "TCoef_Lin";
            this.TCoef_Lin.Size = new System.Drawing.Size(128, 20);
            this.TCoef_Lin.TabIndex = 9;
            this.TCoef_Lin.Text = "Coeficiente Linear";
            // 
            // TFuncao
            // 
            this.TFuncao.AutoSize = true;
            this.TFuncao.Location = new System.Drawing.Point(12, 133);
            this.TFuncao.Name = "TFuncao";
            this.TFuncao.Size = new System.Drawing.Size(59, 20);
            this.TFuncao.TabIndex = 10;
            this.TFuncao.Text = "Função:";
            // 
            // TFuncaoLinear
            // 
            this.TFuncaoLinear.AutoSize = true;
            this.TFuncaoLinear.Location = new System.Drawing.Point(77, 133);
            this.TFuncaoLinear.Name = "TFuncaoLinear";
            this.TFuncaoLinear.Size = new System.Drawing.Size(76, 20);
            this.TFuncaoLinear.TabIndex = 11;
            this.TFuncaoLinear.Text = "y = ax + b";
            // 
            // TX
            // 
            this.TX.AutoSize = true;
            this.TX.Location = new System.Drawing.Point(12, 266);
            this.TX.Name = "TX";
            this.TX.Size = new System.Drawing.Size(77, 20);
            this.TX.TabIndex = 12;
            this.TX.Text = "Valor de X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 302);
            this.Controls.Add(this.TX);
            this.Controls.Add(this.TFuncaoLinear);
            this.Controls.Add(this.TFuncao);
            this.Controls.Add(this.TCoef_Lin);
            this.Controls.Add(this.TCoef_Ang);
            this.Controls.Add(this.Calc_I);
            this.Controls.Add(this.Calc_R);
            this.Controls.Add(this.Value_X);
            this.Controls.Add(this.Value_I);
            this.Controls.Add(this.Value_R);
            this.Controls.Add(this.Value_B);
            this.Controls.Add(this.Value_A);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Value_A;
        private System.Windows.Forms.TextBox Value_B;
        private System.Windows.Forms.TextBox Value_R;
        private System.Windows.Forms.TextBox Value_I;
        private System.Windows.Forms.TextBox Value_X;
        private System.Windows.Forms.Button Calc_R;
        private System.Windows.Forms.Button Calc_I;
        private System.Windows.Forms.Label TCoef_Ang;
        private System.Windows.Forms.Label TCoef_Lin;
        private System.Windows.Forms.Label TFuncao;
        private System.Windows.Forms.Label TFuncaoLinear;
        private System.Windows.Forms.Label TX;
    }
}

