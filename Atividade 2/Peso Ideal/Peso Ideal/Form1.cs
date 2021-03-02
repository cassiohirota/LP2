using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peso_Ideal
{
    public partial class Form1 : Form
    {

        double altura, peso, pesoIdeal, resultado;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            

            if(double.TryParse(mskbxAltura.Text, out altura) && double.TryParse(txtPeso.Text, out peso))
            {
                peso = Convert.ToDouble(txtPeso.Text);

                if (rbtnMasculino.Checked)
                {
                    pesoIdeal = (72.7 * Convert.ToDouble(mskbxAltura.Text)) - 58;
                    if (peso == pesoIdeal)
                        txtResultado.Text = "Peso ideal";
                    else if (peso < pesoIdeal)
                        txtResultado.Text = "Peso abaixo do ideal";
                    else if(peso > pesoIdeal)
                        txtResultado.Text = "Peso acima do ideal";
                }

                if (rbtnFeminino.Checked)
                {
                    pesoIdeal = (62.1 * Convert.ToDouble(mskbxAltura.Text)) - 44.7;
                    pesoIdeal = Math.Round(pesoIdeal, 2);
                    if (pesoIdeal == peso)
                        txtResultado.Text = "Peso ideal";
                    else if (pesoIdeal < peso)
                        txtResultado.Text = "Peso abaixo do ideal";
                    else if(pesoIdeal > peso)
                        txtResultado.Text = "Peso acima do ideal";
                }

                


            }

        }
    }
}
