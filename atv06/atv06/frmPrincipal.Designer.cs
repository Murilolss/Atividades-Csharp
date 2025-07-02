namespace atv06
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(42, 107);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(91, 49);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "0";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o Valor da Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite as horas trabalhadas por Dia:";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(42, 230);
            this.txtHora.Multiline = true;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(91, 49);
            this.txtHora.TabIndex = 2;
            this.txtHora.Text = "0";
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHora_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite os dias trabalhados:";
            // 
            // txtDia
            // 
            this.txtDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(42, 351);
            this.txtDia.Multiline = true;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(91, 49);
            this.txtDia.TabIndex = 4;
            this.txtDia.Text = "0";
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDia_KeyDown);
            // 
            // bntCalcular
            // 
            this.bntCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCalcular.Location = new System.Drawing.Point(42, 491);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(91, 39);
            this.bntCalcular.TabIndex = 6;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(400, 593);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Name = "frmPrincipal";
            this.Text = "Calculo de Sálario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Button bntCalcular;
    }
}

