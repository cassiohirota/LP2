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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstanciaMensalista_Click(object sender, EventArgs e)
        {
            //Criar ou instanciar o objeto da classe mensalista
            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntradaEmpresa.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);

            //get
            MessageBox.Show(
                "Matricula     : " + objMensalista.Matricula + "\n" + 
                "Nome          : " + objMensalista.NomeEmpregado + "\n" +
                "Data Entrada  : " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                "Salario Bruto : " + objMensalista.SalarioBruto().ToString("N2") + "\n" + 
                "Tempo Empresa : " + objMensalista.TempoTrabalho()
                ) ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text), txtNome.Text, 
                Convert.ToDateTime(txtDataEntradaEmpresa.Text), Convert.ToDouble(txtSalarioMensal.Text));

            MessageBox.Show("Matricula: " + objMensalista.Matricula +
                "\n" + "Nome: "+ objMensalista.NomeEmpregado +
                "\n" + "Tempo Trabalhado: " + objMensalista.TempoTrabalho().ToString() +
                "\n" + "Salário: " + objMensalista.SalarioBruto().ToString("N2") +
                "\n" + "Tempo Empresa (Dias): " + objMensalista.TempoTrabalho().ToString());
        }
    }
}
