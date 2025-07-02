using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv10
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtValor.Text);
            decimal meses = Convert.ToDecimal(txtMeses.Text);
            decimal mult;
            decimal vt;

            if (meses == 1)
            {
                mult = valor * 0.05m;
                vt = valor + mult;

                MessageBox.Show("Valor Rendido é igual R$: " + mult.ToString() + "\n" + "Valor Final de R$: " + vt.ToString(), "Valor calculado");
            }

            else if (meses > 1)
            {
                mult = (0.05m * meses) * valor;
                vt = mult + valor;

                MessageBox.Show("Valor Rendido é igual R$: " + mult.ToString() + "\n" + "Valor Final de R$: " + vt.ToString(), "Valor calculado");
            }
        }
    }
}
