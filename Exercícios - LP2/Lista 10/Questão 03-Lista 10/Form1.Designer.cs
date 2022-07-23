
namespace Questão_03_Lista_10
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
            this.calc_movi = new System.Windows.Forms.GroupBox();
            this.value_posic_fin = new System.Windows.Forms.NumericUpDown();
            this.posic_fin_m = new System.Windows.Forms.Label();
            this.label_posic_fin = new System.Windows.Forms.Label();
            this.tempo_s = new System.Windows.Forms.Label();
            this.value_tempo = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.velo_m_s = new System.Windows.Forms.Label();
            this.posic_ini_m = new System.Windows.Forms.Label();
            this.value_velo = new System.Windows.Forms.NumericUpDown();
            this.label_velo = new System.Windows.Forms.Label();
            this.value_posic_ini = new System.Windows.Forms.NumericUpDown();
            this.label_posic_ini = new System.Windows.Forms.Label();
            this.conv_velo = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.value_m_s = new System.Windows.Forms.NumericUpDown();
            this.value_km_h = new System.Windows.Forms.NumericUpDown();
            this.label_m_s = new System.Windows.Forms.Label();
            this.label_km_h = new System.Windows.Forms.Label();
            this.calc_movi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_posic_fin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_tempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_velo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_posic_ini)).BeginInit();
            this.conv_velo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_m_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_km_h)).BeginInit();
            this.SuspendLayout();
            // 
            // calc_movi
            // 
            this.calc_movi.Controls.Add(this.value_posic_fin);
            this.calc_movi.Controls.Add(this.posic_fin_m);
            this.calc_movi.Controls.Add(this.label_posic_fin);
            this.calc_movi.Controls.Add(this.tempo_s);
            this.calc_movi.Controls.Add(this.value_tempo);
            this.calc_movi.Controls.Add(this.button1);
            this.calc_movi.Controls.Add(this.velo_m_s);
            this.calc_movi.Controls.Add(this.posic_ini_m);
            this.calc_movi.Controls.Add(this.value_velo);
            this.calc_movi.Controls.Add(this.label_velo);
            this.calc_movi.Controls.Add(this.value_posic_ini);
            this.calc_movi.Controls.Add(this.label_posic_ini);
            this.calc_movi.Location = new System.Drawing.Point(12, 12);
            this.calc_movi.Name = "calc_movi";
            this.calc_movi.Size = new System.Drawing.Size(401, 212);
            this.calc_movi.TabIndex = 0;
            this.calc_movi.TabStop = false;
            this.calc_movi.Text = "Cálculo do Movimento";
            // 
            // value_posic_fin
            // 
            this.value_posic_fin.DecimalPlaces = 2;
            this.value_posic_fin.Location = new System.Drawing.Point(128, 163);
            this.value_posic_fin.Name = "value_posic_fin";
            this.value_posic_fin.ReadOnly = true;
            this.value_posic_fin.Size = new System.Drawing.Size(73, 27);
            this.value_posic_fin.TabIndex = 12;
            // 
            // posic_fin_m
            // 
            this.posic_fin_m.AutoSize = true;
            this.posic_fin_m.Location = new System.Drawing.Point(207, 165);
            this.posic_fin_m.Name = "posic_fin_m";
            this.posic_fin_m.Size = new System.Drawing.Size(22, 20);
            this.posic_fin_m.TabIndex = 11;
            this.posic_fin_m.Text = "m";
            // 
            // label_posic_fin
            // 
            this.label_posic_fin.AutoSize = true;
            this.label_posic_fin.Location = new System.Drawing.Point(6, 165);
            this.label_posic_fin.Name = "label_posic_fin";
            this.label_posic_fin.Size = new System.Drawing.Size(116, 20);
            this.label_posic_fin.TabIndex = 9;
            this.label_posic_fin.Text = "Posição Final (S)";
            // 
            // tempo_s
            // 
            this.tempo_s.AutoSize = true;
            this.tempo_s.Location = new System.Drawing.Point(331, 123);
            this.tempo_s.Name = "tempo_s";
            this.tempo_s.Size = new System.Drawing.Size(15, 20);
            this.tempo_s.TabIndex = 8;
            this.tempo_s.Text = "s";
            // 
            // value_tempo
            // 
            this.value_tempo.DecimalPlaces = 2;
            this.value_tempo.Location = new System.Drawing.Point(252, 121);
            this.value_tempo.Name = "value_tempo";
            this.value_tempo.Size = new System.Drawing.Size(73, 27);
            this.value_tempo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Movimentar durante x segundos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // velo_m_s
            // 
            this.velo_m_s.AutoSize = true;
            this.velo_m_s.Location = new System.Drawing.Point(195, 83);
            this.velo_m_s.Name = "velo_m_s";
            this.velo_m_s.Size = new System.Drawing.Size(34, 20);
            this.velo_m_s.TabIndex = 5;
            this.velo_m_s.Text = "m/s";
            // 
            // posic_ini_m
            // 
            this.posic_ini_m.AutoSize = true;
            this.posic_ini_m.Location = new System.Drawing.Point(224, 46);
            this.posic_ini_m.Name = "posic_ini_m";
            this.posic_ini_m.Size = new System.Drawing.Size(22, 20);
            this.posic_ini_m.TabIndex = 4;
            this.posic_ini_m.Text = "m";
            // 
            // value_velo
            // 
            this.value_velo.DecimalPlaces = 2;
            this.value_velo.Location = new System.Drawing.Point(116, 81);
            this.value_velo.Name = "value_velo";
            this.value_velo.Size = new System.Drawing.Size(73, 27);
            this.value_velo.TabIndex = 3;
            // 
            // label_velo
            // 
            this.label_velo.AutoSize = true;
            this.label_velo.Location = new System.Drawing.Point(6, 83);
            this.label_velo.Name = "label_velo";
            this.label_velo.Size = new System.Drawing.Size(104, 20);
            this.label_velo.TabIndex = 2;
            this.label_velo.Text = "Velocidade (v)";
            // 
            // value_posic_ini
            // 
            this.value_posic_ini.DecimalPlaces = 2;
            this.value_posic_ini.Location = new System.Drawing.Point(145, 44);
            this.value_posic_ini.Name = "value_posic_ini";
            this.value_posic_ini.Size = new System.Drawing.Size(73, 27);
            this.value_posic_ini.TabIndex = 1;
            // 
            // label_posic_ini
            // 
            this.label_posic_ini.AutoSize = true;
            this.label_posic_ini.Location = new System.Drawing.Point(6, 46);
            this.label_posic_ini.Name = "label_posic_ini";
            this.label_posic_ini.Size = new System.Drawing.Size(133, 20);
            this.label_posic_ini.TabIndex = 0;
            this.label_posic_ini.Text = "Posição Inicial (So)";
            // 
            // conv_velo
            // 
            this.conv_velo.Controls.Add(this.button3);
            this.conv_velo.Controls.Add(this.button2);
            this.conv_velo.Controls.Add(this.value_m_s);
            this.conv_velo.Controls.Add(this.value_km_h);
            this.conv_velo.Controls.Add(this.label_m_s);
            this.conv_velo.Controls.Add(this.label_km_h);
            this.conv_velo.Location = new System.Drawing.Point(12, 230);
            this.conv_velo.Name = "conv_velo";
            this.conv_velo.Size = new System.Drawing.Size(401, 117);
            this.conv_velo.TabIndex = 1;
            this.conv_velo.TabStop = false;
            this.conv_velo.Text = "Conversor de Velocidade";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(195, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "km/h";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(116, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "m/s";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // value_m_s
            // 
            this.value_m_s.DecimalPlaces = 2;
            this.value_m_s.Location = new System.Drawing.Point(274, 64);
            this.value_m_s.Name = "value_m_s";
            this.value_m_s.Size = new System.Drawing.Size(73, 27);
            this.value_m_s.TabIndex = 9;
            // 
            // value_km_h
            // 
            this.value_km_h.DecimalPlaces = 2;
            this.value_km_h.Location = new System.Drawing.Point(37, 64);
            this.value_km_h.Name = "value_km_h";
            this.value_km_h.Size = new System.Drawing.Size(73, 27);
            this.value_km_h.TabIndex = 8;
            // 
            // label_m_s
            // 
            this.label_m_s.AutoSize = true;
            this.label_m_s.Location = new System.Drawing.Point(291, 43);
            this.label_m_s.Name = "label_m_s";
            this.label_m_s.Size = new System.Drawing.Size(34, 20);
            this.label_m_s.TabIndex = 1;
            this.label_m_s.Text = "m/s";
            // 
            // label_km_h
            // 
            this.label_km_h.AutoSize = true;
            this.label_km_h.Location = new System.Drawing.Point(50, 43);
            this.label_km_h.Name = "label_km_h";
            this.label_km_h.Size = new System.Drawing.Size(43, 20);
            this.label_km_h.TabIndex = 0;
            this.label_km_h.Text = "km/h";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 357);
            this.Controls.Add(this.conv_velo);
            this.Controls.Add(this.calc_movi);
            this.Name = "Form1";
            this.Text = "Questão 03-Lista 10";
            this.calc_movi.ResumeLayout(false);
            this.calc_movi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_posic_fin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_tempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_velo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_posic_ini)).EndInit();
            this.conv_velo.ResumeLayout(false);
            this.conv_velo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_m_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value_km_h)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calc_movi;
        private System.Windows.Forms.NumericUpDown value_velo;
        private System.Windows.Forms.Label label_velo;
        private System.Windows.Forms.NumericUpDown value_posic_ini;
        private System.Windows.Forms.Label label_posic_ini;
        private System.Windows.Forms.GroupBox conv_velo;
        private System.Windows.Forms.Label posic_fin_m;
        private System.Windows.Forms.Label label_posic_fin;
        private System.Windows.Forms.Label tempo_s;
        private System.Windows.Forms.NumericUpDown value_tempo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label velo_m_s;
        private System.Windows.Forms.Label posic_ini_m;
        private System.Windows.Forms.NumericUpDown value_posic_fin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown value_m_s;
        private System.Windows.Forms.NumericUpDown value_km_h;
        private System.Windows.Forms.Label label_m_s;
        private System.Windows.Forms.Label label_km_h;
    }
}

