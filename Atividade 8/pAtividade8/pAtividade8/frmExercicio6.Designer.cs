
namespace pAtividade8
{
    partial class frmExercicio6
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
            this.btnMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(287, 190);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(227, 70);
            this.btnMedia.TabIndex = 2;
            this.btnMedia.Text = "Exercicio 6";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // frmExercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMedia);
            this.Name = "frmExercicio6";
            this.Text = "frmExercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedia;
    }
}