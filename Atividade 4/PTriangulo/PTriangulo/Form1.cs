using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        double lado1, lado2, lado3;
        public Form1()
        {
            InitializeComponent();
        }
                
        private void btnCleam_Click(object sender, EventArgs e)
        {
            txtLd1.Text = "";
            txtLd2.Text = "";
            txtLd3.Text = "";
            txtResult.Text = "";
            txtLd1.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if ((Math.Abs(lado2 - lado3) < lado1 && lado1 < lado2 + lado3) && (Math.Abs(lado1 - lado3) < lado2 && lado2 < lado1 + lado3) && (Math.Abs(lado1 - lado2) < lado3 && lado3 < lado1 + lado2))
            {
                MessageBox.Show("Não forma um triângulo, verifique os valores!");
                txtLd1.Focus();
            }
            else if (lado1 == lado2 && lado2 == lado3)
                txtResult.Text = "Triângulo Equilátero";

            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                txtResult.Text = ("Triâgulo Isósceles");
            else
                txtResult.Text = ("Triângulo Escaleno");
        }

        private void txtLd3_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLd3.Text, out lado3))
            {
                MessageBox.Show("Favor colocar apenas números!");
                txtLd1.Focus();
            }
            else if (lado3 <= 0)
            {
                MessageBox.Show("Insira um valor maior que 0");
                txtLd3.Focus();
            }
        }

        private void txtLd2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLd2.Text, out lado2))
            {
                MessageBox.Show("Favor colocar apenas números!");
                txtLd2.Focus();
            }
            else if (lado2 <= 0)
            {
                MessageBox.Show("Insira um valor maior que 0");
                txtLd2.Focus();
            }
        }

        private void txtLd1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLd1.Text, out lado1))
            {
                MessageBox.Show("Favor colocar apenas números!");
                txtLd1.Focus();
            }
            else if (lado1 <= 0)
            {
                MessageBox.Show("Insira um valor maior que 0");
                txtLd1.Focus();
            }
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
