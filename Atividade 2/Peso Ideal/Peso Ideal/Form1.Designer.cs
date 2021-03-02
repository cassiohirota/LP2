
namespace Peso_Ideal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(62, 49);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 17);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(62, 88);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(44, 17);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(65, 336);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(317, 22);
            this.txtResultado.TabIndex = 2;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(161, 88);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(168, 22);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(41, 32);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(92, 21);
            this.rbtnMasculino.TabIndex = 4;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(169, 32);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(86, 21);
            this.rbtnFeminino.TabIndex = 5;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(161, 49);
            this.mskbxAltura.Mask = "0.00";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(168, 22);
            this.mskbxAltura.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(65, 236);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(317, 66);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Location = new System.Drawing.Point(65, 136);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(317, 74);
            this.gbxSexo.TabIndex = 9;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbxSexo;
    }
}

