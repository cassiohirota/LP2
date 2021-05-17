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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";
            string saida = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite um número para a posição " + (i + 1).ToString(), "Entrada de dados");


                Array.Reverse(vetor);

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Valor Inválido");
                    i--;
                }
                else
                {
                    saida = saida + "\n" + vetor[i];

                }
            }
            MessageBox.Show(saida);
        }
    }
}
