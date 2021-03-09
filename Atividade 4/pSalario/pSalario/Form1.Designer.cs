
namespace pSalario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInss = new System.Windows.Forms.Label();
            this.lblIr = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.lblDescInss = new System.Windows.Forms.Label();
            this.lblDescIr = new System.Windows.Forms.Label();
            this.msktxtSalario = new System.Windows.Forms.MaskedTextBox();
            this.msktxtFilhos = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtInss = new System.Windows.Forms.TextBox();
            this.txtIr = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtDescInss = new System.Windows.Forms.TextBox();
            this.txtDescIr = new System.Windows.Forms.TextBox();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rdbtnMasculino = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(44, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(127, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Funcionário:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(44, 79);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(94, 17);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário Bruto:";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(44, 125);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(49, 17);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Filhos:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(44, 213);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(31, 17);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Info";
            this.lblInfo.Visible = false;
            // 
            // lblInss
            // 
            this.lblInss.AutoSize = true;
            this.lblInss.Location = new System.Drawing.Point(44, 268);
            this.lblInss.Name = "lblInss";
            this.lblInss.Size = new System.Drawing.Size(94, 17);
            this.lblInss.TabIndex = 4;
            this.lblInss.Text = "Aliquota INSS";
            // 
            // lblIr
            // 
            this.lblIr.AutoSize = true;
            this.lblIr.Location = new System.Drawing.Point(44, 310);
            this.lblIr.Name = "lblIr";
            this.lblIr.Size = new System.Drawing.Size(76, 17);
            this.lblIr.TabIndex = 5;
            this.lblIr.Text = "Aliquota IR";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(44, 351);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(100, 17);
            this.lblSalFamilia.TabIndex = 6;
            this.lblSalFamilia.Text = "Salário Familia";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Location = new System.Drawing.Point(42, 396);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(102, 17);
            this.lblSalLiq.TabIndex = 7;
            this.lblSalLiq.Text = "Salário Liquido";
            // 
            // lblDescInss
            // 
            this.lblDescInss.AutoSize = true;
            this.lblDescInss.Location = new System.Drawing.Point(409, 268);
            this.lblDescInss.Name = "lblDescInss";
            this.lblDescInss.Size = new System.Drawing.Size(103, 17);
            this.lblDescInss.TabIndex = 8;
            this.lblDescInss.Text = "Desconto IRSS";
            // 
            // lblDescIr
            // 
            this.lblDescIr.AutoSize = true;
            this.lblDescIr.Location = new System.Drawing.Point(409, 310);
            this.lblDescIr.Name = "lblDescIr";
            this.lblDescIr.Size = new System.Drawing.Size(85, 17);
            this.lblDescIr.TabIndex = 9;
            this.lblDescIr.Text = "Desconto IR";
            // 
            // msktxtSalario
            // 
            this.msktxtSalario.Location = new System.Drawing.Point(186, 73);
            this.msktxtSalario.Mask = "00000.00";
            this.msktxtSalario.Name = "msktxtSalario";
            this.msktxtSalario.Size = new System.Drawing.Size(224, 22);
            this.msktxtSalario.TabIndex = 10;
            // 
            // msktxtFilhos
            // 
            this.msktxtFilhos.Location = new System.Drawing.Point(186, 120);
            this.msktxtFilhos.Mask = "00";
            this.msktxtFilhos.Name = "msktxtFilhos";
            this.msktxtFilhos.Size = new System.Drawing.Size(224, 22);
            this.msktxtFilhos.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(186, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 22);
            this.txtNome.TabIndex = 12;
            // 
            // txtInss
            // 
            this.txtInss.Enabled = false;
            this.txtInss.Location = new System.Drawing.Point(174, 263);
            this.txtInss.Name = "txtInss";
            this.txtInss.Size = new System.Drawing.Size(174, 22);
            this.txtInss.TabIndex = 13;
            // 
            // txtIr
            // 
            this.txtIr.Enabled = false;
            this.txtIr.Location = new System.Drawing.Point(174, 305);
            this.txtIr.Name = "txtIr";
            this.txtIr.Size = new System.Drawing.Size(174, 22);
            this.txtIr.TabIndex = 14;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Location = new System.Drawing.Point(174, 346);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(174, 22);
            this.txtSalFamilia.TabIndex = 15;
            // 
            // txtDescInss
            // 
            this.txtDescInss.Enabled = false;
            this.txtDescInss.Location = new System.Drawing.Point(526, 263);
            this.txtDescInss.Name = "txtDescInss";
            this.txtDescInss.Size = new System.Drawing.Size(147, 22);
            this.txtDescInss.TabIndex = 16;
            // 
            // txtDescIr
            // 
            this.txtDescIr.Enabled = false;
            this.txtDescIr.Location = new System.Drawing.Point(526, 307);
            this.txtDescIr.Name = "txtDescIr";
            this.txtDescIr.Size = new System.Drawing.Size(147, 22);
            this.txtDescIr.TabIndex = 17;
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Enabled = false;
            this.txtSalLiq.Location = new System.Drawing.Point(174, 391);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(174, 22);
            this.txtSalLiq.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnFeminino);
            this.groupBox1.Controls.Add(this.rdbtnMasculino);
            this.groupBox1.Location = new System.Drawing.Point(473, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 113);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdbtnFeminino
            // 
            this.rdbtnFeminino.AutoSize = true;
            this.rdbtnFeminino.Location = new System.Drawing.Point(31, 68);
            this.rdbtnFeminino.Name = "rdbtnFeminino";
            this.rdbtnFeminino.Size = new System.Drawing.Size(86, 21);
            this.rdbtnFeminino.TabIndex = 1;
            this.rdbtnFeminino.TabStop = true;
            this.rdbtnFeminino.Text = "Feminino";
            this.rdbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbtnMasculino
            // 
            this.rdbtnMasculino.AutoSize = true;
            this.rdbtnMasculino.Checked = true;
            this.rdbtnMasculino.Location = new System.Drawing.Point(31, 41);
            this.rdbtnMasculino.Name = "rdbtnMasculino";
            this.rdbtnMasculino.Size = new System.Drawing.Size(92, 21);
            this.rdbtnMasculino.TabIndex = 0;
            this.rdbtnMasculino.TabStop = true;
            this.rdbtnMasculino.Text = "Masculino";
            this.rdbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(504, 163);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(78, 21);
            this.ckbxCasado.TabIndex = 20;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(47, 163);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(363, 31);
            this.btnVerificar.TabIndex = 21;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.txtDescIr);
            this.Controls.Add(this.txtDescInss);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtIr);
            this.Controls.Add(this.txtInss);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.msktxtFilhos);
            this.Controls.Add(this.msktxtSalario);
            this.Controls.Add(this.lblDescIr);
            this.Controls.Add(this.lblDescInss);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblIr);
            this.Controls.Add(this.lblInss);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblInss;
        private System.Windows.Forms.Label lblIr;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDescInss;
        private System.Windows.Forms.Label lblDescIr;
        private System.Windows.Forms.MaskedTextBox msktxtSalario;
        private System.Windows.Forms.MaskedTextBox msktxtFilhos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtInss;
        private System.Windows.Forms.TextBox txtIr;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtDescInss;
        private System.Windows.Forms.TextBox txtDescIr;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnFeminino;
        private System.Windows.Forms.RadioButton rdbtnMasculino;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Button btnVerificar;
    }
}

