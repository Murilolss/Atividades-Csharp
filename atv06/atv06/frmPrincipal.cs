using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv06
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            MessageBox.Show(
        "Atenção!\nUse **vírgula** ( , ) para números decimais.\nExemplo: 1,5 e não 1.5.",
        "Aviso Importante",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(txtValor.Text);
            decimal n2 = Convert.ToDecimal(txtHora.Text);
            decimal n3 = Convert.ToDecimal(txtDia.Text);
            decimal vt = n1 * n2;
            decimal vm = vt * n3;

            MessageBox.Show("Valor Mensal é igual R$: " + vm, "Valor calculado");

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHora.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtHora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDia.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntCalcular.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
