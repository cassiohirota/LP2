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
    public partial class frmExercicio4 : Form
    {
        double salario, salarioBruto, gratificacao, producao, b, c, d;

        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtSalario.Text, out salario) && double.TryParse(txtGratificacao.Text, out gratificacao) && double.TryParse(txtProducao.Text, out producao))
            {
             
                if(producao >= 100) { 
                    b = 1;
                }
                else { 
                    b = 0;
                }
                if (producao >= 120) { 
                    c = 1;
                }
                else { 
                    c = 0;
                }
                if (producao >= 150)
                {
                    d = 1;
                }
                else { 
                    d = 0;
                }

                if (salario < 7000)
                {
                    salarioBruto = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;
                }
                else if (salario >= 7000 && producao >= 150 && gratificacao > 0)
                {
                    salarioBruto = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;
                }
                else
                {
                    salarioBruto = 7000;
                }

            }
                MessageBox.Show("O salário bruto do " + txtNome.Text + " é " + "R$ " + salarioBruto.ToString("N2"));

        }
    }
}
