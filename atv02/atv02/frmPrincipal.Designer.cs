namespace atv02
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.bntMedia = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(104, 74);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(71, 42);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.Text = "0";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum1_KeyDown);
            // 
            // txtNum4
            // 
            this.txtNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum4.Location = new System.Drawing.Point(429, 74);
            this.txtNum4.Multiline = true;
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(71, 42);
            this.txtNum4.TabIndex = 1;
            this.txtNum4.Text = "0";
            this.txtNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum4_KeyDown);
            // 
            // txtNum3
            // 
            this.txtNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum3.Location = new System.Drawing.Point(320, 74);
            this.txtNum3.Multiline = true;
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(71, 42);
            this.txtNum3.TabIndex = 2;
            this.txtNum3.Text = "0";
            this.txtNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum3.TextChanged += new System.EventHandler(this.txtNum3_TextChanged);
            this.txtNum3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum3_KeyDown);
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(214, 74);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(71, 42);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.Text = "0";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            this.txtNum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum2_KeyDown);
            // 
            // bntMedia
            // 
            this.bntMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMedia.Location = new System.Drawing.Point(258, 163);
            this.bntMedia.Name = "bntMedia";
            this.bntMedia.Size = new System.Drawing.Size(71, 42);
            this.bntMedia.TabIndex = 4;
            this.bntMedia.Text = "Média";
            this.bntMedia.UseVisualStyleBackColor = true;
            this.bntMedia.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(258, 271);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(71, 42);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(587, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.bntMedia);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum1);
            this.Name = "frmPrincipal";
            this.Text = "Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button bntMedia;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
    }
}

