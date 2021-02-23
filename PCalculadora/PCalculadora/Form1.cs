using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {

        double num1, num2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
            {

                resultado = Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text);

                txtResultado.Text = resultado.ToString();
            }
            else {

                MessageBox.Show("Valor invalido");
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
            {

                resultado = Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text);

                txtResultado.Text = resultado.ToString();
            }
            else
            {

                MessageBox.Show("Valor invalido");
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
            {

                resultado = Convert.ToDouble(txtNum1.Text) * Convert.ToDouble(txtNum2.Text);

                txtResultado.Text = resultado.ToString();
            }
            else
            {

                MessageBox.Show("Valor invalido");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
            {

                resultado = Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text);

                txtResultado.Text = resultado.ToString();
            }
            else
            {

                MessageBox.Show("Valor invalido");
            }
        }
    }
}
