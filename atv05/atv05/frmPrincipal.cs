using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv05
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(txtNum1.Text);
            int n2 = Convert.ToInt16(txtNum2.Text);
            int area = n1 * n2;
            int darea  = area * 2;
            txtArea.Text = area.ToString();
            txtDarea.Text = darea.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
