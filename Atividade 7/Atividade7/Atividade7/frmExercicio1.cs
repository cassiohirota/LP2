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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            string[] frase = new string[100];
            int cont;
            char espaço = ' ';
            cont = 0;

            string a = rtxtBox.Text;

            char[] b = a.ToCharArray();


            foreach (char c in b)
            {
                if (Char.Equals(c, espaço))
                {
                    cont++;
                }
            }

            MessageBox.Show("A frase tem " + cont + " espaços");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            string[] frase = new string[100];
            int cont;
            char r = 'r';
            char R = 'R';
            cont = 0;

            string a = rtxtBox.Text;

            char[] b = a.ToCharArray();


            foreach (char c in b)
            {
                if (Char.Equals(c, r) || Char.Equals(c, R))
                {
                    cont++;
                }
            }

            MessageBox.Show("A frase tem " + cont + " Rs");
        }
    }
}
