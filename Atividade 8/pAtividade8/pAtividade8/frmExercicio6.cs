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
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            int aluno = 20;
            double[,] nota = new double[aluno,3];
            double[] media = new double[aluno];
            string auxiliar = "";

                for (int i = 0; i < nota.GetLength(0); i++) {
                    media[i] = 0;
                    for (int j = 0; j < nota.GetLength(1); j++) { 
                        auxiliar = Interaction.InputBox("Digite a nota " + (j + 1).ToString() + " do aluno " + (i + 1).ToString(), "Entrada de dados");

                        if (!double.TryParse(auxiliar, out nota[i, j]))
                        {
                            MessageBox.Show("Valor Inválido");
                            i--;
                        }

                    media[i] = media[i] + nota[i, j];
                    }

                media[i] = media[i] / 3;
                }
                for(int i = 0; i < nota.GetLength(0); i++)
                {
                    MessageBox.Show("Aluno " + (i+1).ToString() + " = " + media[i].ToString("N1"));
                }
            


        }
    }
}
