using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class frmExercicio2 : Form
    {

        double num, result;


        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            result = 1;

            if (double.TryParse(txtN.Text, out num))
            {
                num = Convert.ToDouble(txtN.Text);

                if (num <= 0)
                    MessageBox.Show("Digite um número maior que 0!");
                else
                {
                    for (double i = 2; i <= num; i++)
                    {
                        result = result + (1/i);
                    }
                }

                MessageBox.Show("O cálculo de H é " + result.ToString("N3"));
            }
            else
            {
                MessageBox.Show("Valor invalido");
            }
        }
    }
}
