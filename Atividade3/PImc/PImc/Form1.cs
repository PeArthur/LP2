using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PImc
{
    public partial class Form1 : Form
    {
        double peso, altura, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void mskbx2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxNum2.Text, out altura))
            {
                MessageBox.Show("Favor colocar apenas números!");
                mskbxNum2.Focus();
            }
            else if (altura <= 0)
                MessageBox.Show("Insira um valor maior que 0");
            mskbxNum2.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mskbxNum1.Text = "";
            mskbxNum2.Text = "";
            txtResult.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            result = peso / (altura * altura);
            result = Math.Round(result);

            if (result < 18.5)
                txtResult.Text = "Magreza";
            else if (result < 24.9)
                txtResult.Text  = "Normal";
            else if (result < 29.9)
                txtResult.Text = "Sobrepeso";
            else if (result < 39.9)
                txtResult.Text = "Obesidade";
            else
                txtResult.Text = "Obesidade Grave";
        }

        private void mskbx1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxNum1.Text, out peso))
            {
                MessageBox.Show("Favor colocar apenas números!");
                mskbxNum1.Focus();
            }
            else if (peso <= 0)
            {
                MessageBox.Show("Insira um valor maior que 0");
                mskbxNum1.Focus();
            }
        }
    }
}
