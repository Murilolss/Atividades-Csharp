using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv15
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCb.Focus();
                e.SuppressKeyPress = true;

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFl.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSm.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntCalcular.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            decimal bv = Convert.ToDecimal(txtBv.Text);
            decimal cb = Convert.ToDecimal(txtCb.Text);
            decimal fl = Convert.ToDecimal(txtFl.Text);
            decimal sm = Convert.ToDecimal(txtSm.Text);

            decimal comi, comipe, salariofi, lucro, rt, ct, ts;

            /*
            fl = funcionarios
            sm = salario minimo
            cb = Preço de Custo
            bv = Bicicletas vendidas
            comi = comissão
            comipe = comissão por empregado
            salariofi = salario final
            lucro = lucro
            rt = receita total
            ct = custo total
            ts = total de salarios
            */

            comi = (cb * 0.15m) * bv;
            comipe = comi / fl;
            salariofi = (sm * 2.0m) + comipe;

            rt = (1.5m * cb) * bv;
            ct = cb * bv;
            ts = fl * salariofi;
            lucro = (rt - ct) - ts;

            MessageBox.Show("O salário final de cada empregado é de R$: " + salariofi.ToString() + "\n" + "O lucro da empresa é de R$: " + lucro.ToString(), "Lucro da Loja");
        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
