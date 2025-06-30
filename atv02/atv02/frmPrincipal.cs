using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(txtNum1.Text);
            decimal n2 = Convert.ToDecimal(txtNum2.Text);
            decimal n3 = Convert.ToDecimal(txtNum3.Text);
            decimal n4 = Convert.ToDecimal(txtNum4.Text);
            decimal resultado = (n1 + n2 + n3 + n4) / 4;
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

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNum3.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtNum3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNum3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNum4.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtNum4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntMedia.Focus();
                e.SuppressKeyPress = true;

            }
        }
    }
}
