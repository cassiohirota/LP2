using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pSalario
{
    public partial class Form1 : Form
    {
        string nome, estadoCivil;
        double salBruto, filhos, salFamilia;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNome.Text) || (txtNome.Text.Length < 5))
            {
                MessageBox.Show("Nome Invalido");
            }
            else { 
                if (double.TryParse(msktxtSalario.Text, out salBruto) && double.TryParse(msktxtFilhos.Text, out filhos))
                {
                    double salLiq = 0;
                    double descInss = 0;
                    double descIr = 0;

                    lblInfo.Visible = true;
                    nome = txtNome.Text;

                    if(ckbxCasado.Checked)
                        estadoCivil = "casado(a)";
                    else
                        estadoCivil = "solteiro(a)";
                

                    if(rdbtnMasculino.Checked)
                        lblInfo.Text = "Os descontos do salário do Sr. " + nome + " que é " + estadoCivil + " e que tem " + filhos + "  filho(s) são:" ;
                    else
                        lblInfo.Text = "Os descontos do salário do Sra. " + nome + " que é " + estadoCivil + " e que tem " + filhos + "  filho(s) são:";

                    if(salBruto <= 800.47)
                    {
                        txtInss.Text = "7.65%";
                        descInss = 0.0765 * salBruto;
                    }
                    else if(salBruto <= 1050)
                    {
                        txtInss.Text = "8.65%";
                        descInss = 0.0865 * salBruto;
                    }
                    else if(salBruto <= 1400.77)
                    {
                        txtInss.Text = "9%";
                        descInss = 0.09 * salBruto;
                    }
                    else if(salBruto <= 2801.56)
                    {
                        txtInss.Text = "11%";
                        descInss = 0.11 * salBruto;
                    }
                    else if(salBruto > 2801.56)
                    {
                        txtInss.Text = "R$ 308.17";
                        descInss = 308.17;
                    }
                    descInss = Math.Round(descInss, 2);
                    txtDescInss.Text = "R$ " + descInss.ToString();

                    if (salBruto <= 1257.12)
                    {
                        txtIr.Text = "Isento";
                        descIr = 0;
                    }
                    else if(salBruto <= 2512.08)
                    {
                        txtIr.Text = "15%";
                        descIr = 0.15 * salBruto;
                    }
                    else if(salBruto > 2512.08)
                    {
                        txtIr.Text = "27.5%";
                        descIr = 0.275 * salBruto;
                    }
                    descIr = Math.Round(descIr, 2);
                    txtDescIr.Text = "R$ " + descIr.ToString();


                    if (salBruto <= 435.52)
                        salFamilia = 22.33 * filhos;
                    else if (salBruto <= 654.61)
                        salFamilia = 15.74 * filhos;
                    else if (salBruto > 654.61)
                        salFamilia = 0;
                    txtSalFamilia.Text = "R$ " + salFamilia.ToString();

                    salLiq = salBruto - descInss - descIr + salFamilia;
                    txtSalLiq.Text = "R$ " + salLiq.ToString(); 
                }
                else
                {
                    MessageBox.Show("Preencha os campos");
                }
            }
        }
    }
}
