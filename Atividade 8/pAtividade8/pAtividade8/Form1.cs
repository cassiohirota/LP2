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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 objfrm2 = new frmExercicio2();
            objfrm2.MdiParent = this;
            objfrm2.WindowState = FormWindowState.Maximized;
            objfrm2.Show();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio1 objfrm1 = new frmExercicio1();
            objfrm1.MdiParent = this;
            objfrm1.WindowState = FormWindowState.Maximized;
            objfrm1.Show();
        }


        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 objfrm3 = new frmExercicio3();
            objfrm3.MdiParent = this;
            objfrm3.WindowState = FormWindowState.Maximized;
            objfrm3.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio5 objfrm5 = new frmExercicio5();
            objfrm5.MdiParent = this;
            objfrm5.WindowState = FormWindowState.Maximized;
            objfrm5.Show();
        }

        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio6 objfrm6 = new frmExercicio6();
            objfrm6.MdiParent = this;
            objfrm6.WindowState = FormWindowState.Maximized;
            objfrm6.Show();
        }

        private void exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio7 objfrm7 = new frmExercicio7();
            objfrm7.MdiParent = this;
            objfrm7.WindowState = FormWindowState.Maximized;
            objfrm7.Show();

        }
    }
}
