using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv03
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            int a, b, q1, q2, soma;

            a = Convert.ToInt16(txtNum1.Text);
            b = Convert.ToInt16(txtNum2.Text);
            q1 = (int)Math.Pow(a, 2);
            q2 = (int)Math.Pow(b, 2);
            soma = q1 + q2;

            txtResultado.Text = Convert.ToString(soma);
        }

        private void txtNum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNum2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtNum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntCalcular.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
