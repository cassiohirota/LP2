
namespace Pclasses
{
    partial class frmMensalista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.lblDataEntradaEmpresa = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.txtDataEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.btnInstanciaMensalista = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(79, 47);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(69, 17);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(79, 83);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Location = new System.Drawing.Point(79, 125);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(105, 17);
            this.lblSalarioMensal.TabIndex = 2;
            this.lblSalarioMensal.Text = "Salário Mensal:";
            // 
            // lblDataEntradaEmpresa
            // 
            this.lblDataEntradaEmpresa.AutoSize = true;
            this.lblDataEntradaEmpresa.Location = new System.Drawing.Point(79, 170);
            this.lblDataEntradaEmpresa.Name = "lblDataEntradaEmpresa";
            this.lblDataEntradaEmpresa.Size = new System.Drawing.Size(172, 17);
            this.lblDataEntradaEmpresa.TabIndex = 3;
            this.lblDataEntradaEmpresa.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(257, 47);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(163, 22);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(257, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(237, 22);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(257, 122);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioMensal.TabIndex = 6;
            // 
            // txtDataEntradaEmpresa
            // 
            this.txtDataEntradaEmpresa.Location = new System.Drawing.Point(257, 167);
            this.txtDataEntradaEmpresa.Name = "txtDataEntradaEmpresa";
            this.txtDataEntradaEmpresa.Size = new System.Drawing.Size(100, 22);
            this.txtDataEntradaEmpresa.TabIndex = 7;
            // 
            // btnInstanciaMensalista
            // 
            this.btnInstanciaMensalista.Location = new System.Drawing.Point(82, 250);
            this.btnInstanciaMensalista.Name = "btnInstanciaMensalista";
            this.btnInstanciaMensalista.Size = new System.Drawing.Size(204, 83);
            this.btnInstanciaMensalista.TabIndex = 8;
            this.btnInstanciaMensalista.Text = "Instanciar Mensalista";
            this.btnInstanciaMensalista.UseVisualStyleBackColor = true;
            this.btnInstanciaMensalista.Click += new System.EventHandler(this.btnInstanciaMensalista_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 83);
            this.button2.TabIndex = 9;
            this.button2.Text = "Instanciar Mensalista passando parâmetros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInstanciaMensalista);
            this.Controls.Add(this.txtDataEntradaEmpresa);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntradaEmpresa);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.Label lblDataEntradaEmpresa;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.TextBox txtDataEntradaEmpresa;
        private System.Windows.Forms.Button btnInstanciaMensalista;
        private System.Windows.Forms.Button button2;
    }
}