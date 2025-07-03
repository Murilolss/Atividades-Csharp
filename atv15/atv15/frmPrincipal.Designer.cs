namespace atv15
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBv = new System.Windows.Forms.TextBox();
            this.txtCb = new System.Windows.Forms.TextBox();
            this.txtFl = new System.Windows.Forms.TextBox();
            this.txtSm = new System.Windows.Forms.TextBox();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.bntFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantos funcionarios tem na loja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o valor do salário mínimo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite o preço de custo da bicicleta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite o número de bicicletas vendidas:";
            // 
            // txtBv
            // 
            this.txtBv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBv.Location = new System.Drawing.Point(16, 90);
            this.txtBv.Multiline = true;
            this.txtBv.Name = "txtBv";
            this.txtBv.Size = new System.Drawing.Size(157, 33);
            this.txtBv.TabIndex = 4;
            this.txtBv.Text = "0";
            this.txtBv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // txtCb
            // 
            this.txtCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCb.Location = new System.Drawing.Point(16, 175);
            this.txtCb.Multiline = true;
            this.txtCb.Name = "txtCb";
            this.txtCb.Size = new System.Drawing.Size(157, 33);
            this.txtCb.TabIndex = 5;
            this.txtCb.Text = "0";
            this.txtCb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // txtFl
            // 
            this.txtFl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFl.Location = new System.Drawing.Point(16, 265);
            this.txtFl.Multiline = true;
            this.txtFl.Name = "txtFl";
            this.txtFl.Size = new System.Drawing.Size(157, 33);
            this.txtFl.TabIndex = 6;
            this.txtFl.Text = "0";
            this.txtFl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFl.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtFl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // txtSm
            // 
            this.txtSm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSm.Location = new System.Drawing.Point(16, 356);
            this.txtSm.Multiline = true;
            this.txtSm.Name = "txtSm";
            this.txtSm.Size = new System.Drawing.Size(157, 33);
            this.txtSm.TabIndex = 7;
            this.txtSm.Text = "0";
            this.txtSm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // bntCalcular
            // 
            this.bntCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCalcular.Location = new System.Drawing.Point(115, 421);
            this.bntCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(83, 37);
            this.bntCalcular.TabIndex = 14;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // bntFechar
            // 
            this.bntFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFechar.Location = new System.Drawing.Point(16, 421);
            this.bntFechar.Margin = new System.Windows.Forms.Padding(2);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(83, 37);
            this.bntFechar.TabIndex = 15;
            this.bntFechar.Text = "Fechar";
            this.bntFechar.UseVisualStyleBackColor = true;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(529, 545);
            this.Controls.Add(this.bntFechar);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.txtSm);
            this.Controls.Add(this.txtFl);
            this.Controls.Add(this.txtCb);
            this.Controls.Add(this.txtBv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Lucro da Loja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBv;
        private System.Windows.Forms.TextBox txtCb;
        private System.Windows.Forms.TextBox txtFl;
        private System.Windows.Forms.TextBox txtSm;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button bntFechar;
    }
}

