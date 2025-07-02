using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv09
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(txtValor.Text);
            decimal reajuste = n1 * 0.15m;
            decimal final = reajuste + n1;

            MessageBox.Show("Seu novo Salario será de R$: " + final, "Valor calculado");
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntCalcular_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
