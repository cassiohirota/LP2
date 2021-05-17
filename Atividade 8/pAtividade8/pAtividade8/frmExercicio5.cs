using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace pAtividade8
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnDeletarNome_Click(object sender, EventArgs e)
        {
            ArrayList Alunos = new ArrayList() {"Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"};

            Alunos.Remove("Otávio");
            foreach (string elementos in Alunos)
            {
                MessageBox.Show(elementos + ", ");

            }
        }
    }
}
