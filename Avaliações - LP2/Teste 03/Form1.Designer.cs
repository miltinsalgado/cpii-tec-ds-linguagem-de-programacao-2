
namespace Teste_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.valor_Ano = new System.Windows.Forms.NumericUpDown();
            this.label_Paridade = new System.Windows.Forms.Label();
            this.button_Inserir = new System.Windows.Forms.Button();
            this.ListBox_Anos = new System.Windows.Forms.ListBox();
            this.button_Limpar_Lista = new System.Windows.Forms.Button();
            this.button_Avaliar_Sequência = new System.Windows.Forms.Button();
            this.textBox_k_alternante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.valor_Ano)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada";
            // 
            // valor_Ano
            // 
            this.valor_Ano.Location = new System.Drawing.Point(78, 18);
            this.valor_Ano.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valor_Ano.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valor_Ano.Name = "valor_Ano";
            this.valor_Ano.Size = new System.Drawing.Size(78, 27);
            this.valor_Ano.TabIndex = 1;
            this.valor_Ano.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valor_Ano.ValueChanged += new System.EventHandler(this.valor_Ano_ValueChanged);
            // 
            // label_Paridade
            // 
            this.label_Paridade.AutoSize = true;
            this.label_Paridade.Location = new System.Drawing.Point(162, 20);
            this.label_Paridade.Name = "label_Paridade";
            this.label_Paridade.Size = new System.Drawing.Size(79, 20);
            this.label_Paridade.TabIndex = 2;
            this.label_Paridade.Text = "Ano Ímpar";
            // 
            // button_Inserir
            // 
            this.button_Inserir.Location = new System.Drawing.Point(12, 51);
            this.button_Inserir.Name = "button_Inserir";
            this.button_Inserir.Size = new System.Drawing.Size(259, 29);
            this.button_Inserir.TabIndex = 3;
            this.button_Inserir.Text = "Inserir";
            this.button_Inserir.UseVisualStyleBackColor = true;
            this.button_Inserir.Click += new System.EventHandler(this.button_Inserir_Click);
            // 
            // ListBox_Anos
            // 
            this.ListBox_Anos.FormattingEnabled = true;
            this.ListBox_Anos.ItemHeight = 20;
            this.ListBox_Anos.Location = new System.Drawing.Point(12, 86);
            this.ListBox_Anos.Name = "ListBox_Anos";
            this.ListBox_Anos.Size = new System.Drawing.Size(259, 124);
            this.ListBox_Anos.TabIndex = 4;
            // 
            // button_Limpar_Lista
            // 
            this.button_Limpar_Lista.Location = new System.Drawing.Point(12, 216);
            this.button_Limpar_Lista.Name = "button_Limpar_Lista";
            this.button_Limpar_Lista.Size = new System.Drawing.Size(259, 29);
            this.button_Limpar_Lista.TabIndex = 5;
            this.button_Limpar_Lista.Text = "Limpar Lista";
            this.button_Limpar_Lista.UseVisualStyleBackColor = true;
            this.button_Limpar_Lista.Click += new System.EventHandler(this.button_Limpar_Lista_Click);
            // 
            // button_Avaliar_Sequência
            // 
            this.button_Avaliar_Sequência.Location = new System.Drawing.Point(12, 251);
            this.button_Avaliar_Sequência.Name = "button_Avaliar_Sequência";
            this.button_Avaliar_Sequência.Size = new System.Drawing.Size(259, 29);
            this.button_Avaliar_Sequência.TabIndex = 6;
            this.button_Avaliar_Sequência.Text = "Avaliar Sequência";
            this.button_Avaliar_Sequência.UseVisualStyleBackColor = true;
            this.button_Avaliar_Sequência.Click += new System.EventHandler(this.button_Avaliar_Sequência_Click);
            // 
            // textBox_k_alternante
            // 
            this.textBox_k_alternante.Location = new System.Drawing.Point(12, 286);
            this.textBox_k_alternante.Name = "textBox_k_alternante";
            this.textBox_k_alternante.ReadOnly = true;
            this.textBox_k_alternante.Size = new System.Drawing.Size(259, 27);
            this.textBox_k_alternante.TabIndex = 7;
            this.textBox_k_alternante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(283, 330);
            this.Controls.Add(this.textBox_k_alternante);
            this.Controls.Add(this.button_Avaliar_Sequência);
            this.Controls.Add(this.button_Limpar_Lista);
            this.Controls.Add(this.ListBox_Anos);
            this.Controls.Add(this.button_Inserir);
            this.Controls.Add(this.label_Paridade);
            this.Controls.Add(this.valor_Ano);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TVA log";
            ((System.ComponentModel.ISupportInitialize)(this.valor_Ano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown valor_Ano;
        private System.Windows.Forms.Label label_Paridade;
        private System.Windows.Forms.Button button_Inserir;
        private System.Windows.Forms.ListBox ListBox_Anos;
        private System.Windows.Forms.Button button_Limpar_Lista;
        private System.Windows.Forms.Button button_Avaliar_Sequência;
        private System.Windows.Forms.TextBox textBox_k_alternante;
    }
}

