using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pAtividade8
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnExe3_Click(object sender, EventArgs e)
        {
            int[] qtdn = new int[10];
            double[] preco = new double[10];
            string auxiliar = "";
            double valorTotal;

            valorTotal = 0;
            for (int i = 0; i < qtdn.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite a quantidade do produto " + (i + 1).ToString(), "Entrada de dados");

                if (!int.TryParse(auxiliar, out qtdn[i]))
                {
                    MessageBox.Show("Valor Inválido");
                    i--;
                }
                auxiliar = Interaction.InputBox("Digite o preço do produto " + (i + 1).ToString(), "Entrada de dados");
                if(!double.TryParse(auxiliar, out preco[i]))
                {
                    MessageBox.Show("Valor Inválido");
                    i--;
                }
                valorTotal = valorTotal + (qtdn[i] * preco[i]);
            }
            MessageBox.Show("O valor total é R$" + valorTotal + ".");
        }
    }
}
