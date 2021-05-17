
namespace pAtividade8
{
    partial class frmExercicio5
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
            this.btnDeletarNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeletarNome
            // 
            this.btnDeletarNome.Location = new System.Drawing.Point(287, 190);
            this.btnDeletarNome.Name = "btnDeletarNome";
            this.btnDeletarNome.Size = new System.Drawing.Size(227, 70);
            this.btnDeletarNome.TabIndex = 1;
            this.btnDeletarNome.Text = "Exercicio 5";
            this.btnDeletarNome.UseVisualStyleBackColor = true;
            this.btnDeletarNome.Click += new System.EventHandler(this.btnDeletarNome_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletarNome);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeletarNome;
    }
}