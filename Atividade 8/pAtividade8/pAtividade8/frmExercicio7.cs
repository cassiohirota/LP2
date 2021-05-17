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
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string valor = Interaction.InputBox("Digite o RA", "Entrada de dados");
            char[] numero = valor.ToCharArray();
            Array.Reverse(numero);
            int ra = int.Parse(numero[0].ToString());

            if(ra == 0)
            {
                ra = 10;
            }

            string[] nome = new string[ra];
            int[] letras = new int[nome.Length];
            string auxiliar = "";
            int cont;

            for (int i = 0; i < nome.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o " + (i + 1).ToString() + "º " + " nome", "Entrada de dados");

                if (string.IsNullOrEmpty(auxiliar))
                {
                    MessageBox.Show("Valor Inválido");
                    i--;
                }

                nome[i] = auxiliar;

                cont = 0;

                foreach (char letra in nome[i])
                {
                    if (letra != ' ')
                        cont++;
                }

                letras[i] = cont;
            }

            for (int i = 0; i < nome.Length; i++)
            {
                listBox1.Items.Add($"O nome: {nome[i]} tem {letras[i]} caracteres. \n");
            }
        }
    }
}
