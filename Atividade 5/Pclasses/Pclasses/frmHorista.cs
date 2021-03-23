using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntradaEmpresa.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFaltas.Text);

            MessageBox.Show("Nome: " + objHorista.NomeEmpregado +
                "\n" + "Matricula: " + objHorista.Matricula + 
                "\n" + "Tempo Trabalhado: " + objHorista.TempoTrabalho().ToString() +
                "\n" + "Salário: " + objHorista.SalarioBruto().ToString("N2"));
        }
    }
}
