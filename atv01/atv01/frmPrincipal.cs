using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv01
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(txtNum1.Text);
            decimal n2 = Convert.ToDecimal(txtNum2.Text);
            decimal resultado = n1 + n2;

            txtResultado.Text = resultado.ToString();
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
                bntSoma.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
