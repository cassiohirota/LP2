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

        double altura, peso, pesoIdeal;

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if(txtPeso.Text == "0")
            {
                txtResultado.Text = "Erro";
            }
        }

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
                    pesoIdeal = (72.7 * altura) - 58;
                    pesoIdeal = Math.Round(pesoIdeal, 2);
                    if (peso == pesoIdeal)
                        txtResultado.Text = "Peso ideal";
                    else if (peso < pesoIdeal)
                        txtResultado.Text = "Peso abaixo do ideal";
                    else if(peso > pesoIdeal)
                        txtResultado.Text = "Peso acima do ideal";
                }

                if (rbtnFeminino.Checked)
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                    pesoIdeal = Math.Round(pesoIdeal, 2);
                    if (pesoIdeal == peso)
                        txtResultado.Text = "Peso ideal";
                    else if (pesoIdeal < peso)
                        txtResultado.Text = "Peso abaixo do ideal";
                    else if (pesoIdeal > peso)
                        txtResultado.Text = "Peso acima do ideal";
                }

                if ((!rbtnMasculino.Checked) && (!rbtnFeminino.Checked))
                    txtResultado.Text = "Selecione o sexo";

            }

        }
    }
}
