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

namespace P30482021033
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            string valor = Interaction.InputBox("Digite o RA", "Entrada de dados");

            char[] numero = valor.ToCharArray();
            Array.Reverse(numero);
            int ra = int.Parse(numero[0].ToString());

            if (ra == 0)
            {
                ra = 10;
            }

            string[] mes = new string[ra];
            double[,] semana = new double[mes.Length, 4];
            double[] totalmes = new double[mes.Length];


            double totalGeral = 0;
            string auxiliar = "";

            for (int i = 0; i < semana.GetLength(0); i++)
            {
                totalmes[i] = 0;
                for (int j = 0; j < semana.GetLength(1); j++)
                {
                    auxiliar = Interaction.InputBox("Digite o valor do mês " + (i + 1).ToString() + " da semana " + (j + 1).ToString(), "Entrada de dados");

                    if (!double.TryParse(auxiliar, out semana[i, j]))
                    {
                        MessageBox.Show("Valor Inválido");
                        j--;
                        continue;
                    }

                    if (semana[i, j] < 0)
                    {
                        MessageBox.Show("Valor Inválido");
                        j--;
                        continue;
                    }

                    totalmes[i] = totalmes[i] + semana[i, j];
                }

                totalGeral = totalGeral + totalmes[i];
            }

            for (int i = 0; i < semana.GetLength(0); i++)
            {
                for (int j = 0; j < semana.GetLength(1); j++)
                {
                    Lstbx.Items.Add($"Total do mês: {i+1} Semana: {j+1} {String.Format("{0:C2}", semana[i, j])}. \n");
                }

                Lstbx.Items.Add($">> Total Mês: {String.Format("{0:C2}", totalmes[i])} \n");
                Lstbx.Items.Add($"------------------------------------ \n");
            }

            Lstbx.Items.Add($">> Total Geral: {String.Format("{0:C2}", totalGeral)} \n");

        }
    }
}
