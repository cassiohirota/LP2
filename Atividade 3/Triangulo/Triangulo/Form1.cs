using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        double a, b, c;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtB.Text) || string.IsNullOrEmpty(txtC.Text))
            {
                txtResultado.Text = "Preencha os campos em branco";
            }
            else
            {
                if(double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b) && double.TryParse(txtC.Text, out c))
                {
                    if((a == b) && (b == c) && (a == c))
                        txtResultado.Text = "Equilatero";
                    else
                        txtResultado.Text = "Isoceles";
                    if ((a != b) && (b != c) && (a != c))
                        txtResultado.Text = "Escaleno";       
                }
                else
                    txtResultado.Text = "Digite números no campo";
            }
        }
    }
}
