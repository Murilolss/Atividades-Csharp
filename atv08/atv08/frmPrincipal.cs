using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv08
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void bntConverter_Click(object sender, EventArgs e)
        {
         
        }

        private void bntConv_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(txtNum1.Text);
            decimal milhas = 0.6214m;
            decimal resultado = n1 * milhas;
            txtResultado.Text = resultado.ToString();
        }

        private void txtNum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                bntConv.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
