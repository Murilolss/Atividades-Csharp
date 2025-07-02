using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv12
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
            decimal mult;
            decimal dias;

            mult = n1 * 1000;
            dias = mult / 50;

            MessageBox.Show("O Alimento Irá durar: " + dias+ " Dias", "Dias calculado");
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntCalcular.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
