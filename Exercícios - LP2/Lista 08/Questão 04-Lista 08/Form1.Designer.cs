
namespace Questão_04_Lista_08
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
            this.Celsius = new System.Windows.Forms.Label();
            this.N_Celsius = new System.Windows.Forms.TextBox();
            this.N_Kelvin = new System.Windows.Forms.TextBox();
            this.N_Fahrenheit = new System.Windows.Forms.TextBox();
            this.Fahrenheit = new System.Windows.Forms.Label();
            this.Kelvin = new System.Windows.Forms.Label();
            this.CtoFK = new System.Windows.Forms.Button();
            this.FtoKC = new System.Windows.Forms.Button();
            this.KtoCF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(157, 45);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(262, 28);
            this.Title.TabIndex = 0;
            this.Title.Text = "Conversor de Temperatura";
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(119, 99);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(83, 20);
            this.Celsius.TabIndex = 1;
            this.Celsius.Text = "Celsius (°C)";
            // 
            // N_Celsius
            // 
            this.N_Celsius.Location = new System.Drawing.Point(99, 122);
            this.N_Celsius.Name = "N_Celsius";
            this.N_Celsius.Size = new System.Drawing.Size(122, 27);
            this.N_Celsius.TabIndex = 2;
            // 
            // N_Kelvin
            // 
            this.N_Kelvin.Location = new System.Drawing.Point(355, 122);
            this.N_Kelvin.Name = "N_Kelvin";
            this.N_Kelvin.Size = new System.Drawing.Size(122, 27);
            this.N_Kelvin.TabIndex = 3;
            // 
            // N_Fahrenheit
            // 
            this.N_Fahrenheit.Location = new System.Drawing.Point(227, 122);
            this.N_Fahrenheit.Name = "N_Fahrenheit";
            this.N_Fahrenheit.Size = new System.Drawing.Size(122, 27);
            this.N_Fahrenheit.TabIndex = 4;
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.Location = new System.Drawing.Point(236, 99);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(104, 20);
            this.Fahrenheit.TabIndex = 5;
            this.Fahrenheit.Text = "Fahrenheit (°F)";
            // 
            // Kelvin
            // 
            this.Kelvin.AutoSize = true;
            this.Kelvin.Location = new System.Drawing.Point(384, 99);
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.Size = new System.Drawing.Size(72, 20);
            this.Kelvin.TabIndex = 6;
            this.Kelvin.Text = "Kelvin (K)";
            // 
            // CtoFK
            // 
            this.CtoFK.Location = new System.Drawing.Point(99, 155);
            this.CtoFK.Name = "CtoFK";
            this.CtoFK.Size = new System.Drawing.Size(122, 76);
            this.CtoFK.TabIndex = 7;
            this.CtoFK.Text = "Converter para °F e K";
            this.CtoFK.UseVisualStyleBackColor = true;
            this.CtoFK.Click += new System.EventHandler(this.CtoKF_Click);
            // 
            // FtoKC
            // 
            this.FtoKC.Location = new System.Drawing.Point(227, 155);
            this.FtoKC.Name = "FtoKC";
            this.FtoKC.Size = new System.Drawing.Size(122, 76);
            this.FtoKC.TabIndex = 8;
            this.FtoKC.Text = "Converter para °C e K";
            this.FtoKC.UseVisualStyleBackColor = true;
            this.FtoKC.Click += new System.EventHandler(this.FtoKC_Click);
            // 
            // KtoCF
            // 
            this.KtoCF.Location = new System.Drawing.Point(355, 155);
            this.KtoCF.Name = "KtoCF";
            this.KtoCF.Size = new System.Drawing.Size(122, 76);
            this.KtoCF.TabIndex = 9;
            this.KtoCF.Text = "Converter para °C e °F";
            this.KtoCF.UseVisualStyleBackColor = true;
            this.KtoCF.Click += new System.EventHandler(this.KtoCF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 267);
            this.Controls.Add(this.KtoCF);
            this.Controls.Add(this.FtoKC);
            this.Controls.Add(this.CtoFK);
            this.Controls.Add(this.Kelvin);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.N_Fahrenheit);
            this.Controls.Add(this.N_Kelvin);
            this.Controls.Add(this.N_Celsius);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Celsius;
        private System.Windows.Forms.TextBox N_Celsius;
        private System.Windows.Forms.TextBox N_Kelvin;
        private System.Windows.Forms.TextBox N_Fahrenheit;
        private System.Windows.Forms.Label Fahrenheit;
        private System.Windows.Forms.Label Kelvin;
        private System.Windows.Forms.Button CtoFK;
        private System.Windows.Forms.Button FtoKC;
        private System.Windows.Forms.Button KtoCF;
    }
}

