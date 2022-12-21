using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030482021033
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try { 
            conexao = new SqlConnection("Data Source=CASSIO\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
            conexao.Open();
            }
            catch (SqlException ex){
                MessageBox.Show("Erro de banco de dados " + ex.Message);
            }
            catch(Exception ex){
                MessageBox.Show("Outros tipos de erros " + ex.Message);
            }
        }

        private void cadastroVacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVacina FRMVacina = new frmVacina();
            FRMVacina.MdiParent = this;
            FRMVacina.WindowState = FormWindowState.Maximized;
            FRMVacina.Show();

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre FRMSobre = new frmSobre();
            FRMSobre.MdiParent = this;
            FRMSobre.WindowState = FormWindowState.Maximized;
            FRMSobre.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
