
namespace PVacina0030482021033
{
    partial class frmVacina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacina));
            this.bnvVacina = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbVacina = new System.Windows.Forms.TabControl();
            this.tabVacina = new System.Windows.Forms.TabPage();
            this.dgvVacina = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.cbxGrupoPrioritarioVacina = new System.Windows.Forms.ComboBox();
            this.cbxComorbidadeVacina = new System.Windows.Forms.ComboBox();
            this.cbxTipoVacina = new System.Windows.Forms.ComboBox();
            this.mskbxRgVacina = new System.Windows.Forms.MaskedTextBox();
            this.mskbxCpfVacina = new System.Windows.Forms.MaskedTextBox();
            this.dtVacina = new System.Windows.Forms.DateTimePicker();
            this.dtNascVacina = new System.Windows.Forms.DateTimePicker();
            this.txtEndVacina = new System.Windows.Forms.TextBox();
            this.txtNomeVacina = new System.Windows.Forms.TextBox();
            this.txtIdVacina = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEnfermeiro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bnvVacina)).BeginInit();
            this.bnvVacina.SuspendLayout();
            this.tbVacina.SuspendLayout();
            this.tabVacina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacina)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvVacina
            // 
            this.bnvVacina.AddNewItem = null;
            this.bnvVacina.CountItem = this.bindingNavigatorCountItem;
            this.bnvVacina.DeleteItem = null;
            this.bnvVacina.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnvVacina.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.btnAlterar,
            this.btnSalvar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnvVacina.Location = new System.Drawing.Point(0, 0);
            this.bnvVacina.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvVacina.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvVacina.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvVacina.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvVacina.Name = "bnvVacina";
            this.bnvVacina.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvVacina.Size = new System.Drawing.Size(866, 27);
            this.bnvVacina.TabIndex = 0;
            this.bnvVacina.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(29, 24);
            this.btnNovo.Text = "Incluir Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(29, 24);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(29, 24);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(29, 24);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(29, 24);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(29, 24);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbVacina
            // 
            this.tbVacina.Controls.Add(this.tabVacina);
            this.tbVacina.Controls.Add(this.tabPage2);
            this.tbVacina.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbVacina.Location = new System.Drawing.Point(0, 50);
            this.tbVacina.Name = "tbVacina";
            this.tbVacina.SelectedIndex = 0;
            this.tbVacina.Size = new System.Drawing.Size(854, 412);
            this.tbVacina.TabIndex = 1;
            // 
            // tabVacina
            // 
            this.tabVacina.Controls.Add(this.dgvVacina);
            this.tabVacina.Location = new System.Drawing.Point(4, 25);
            this.tabVacina.Name = "tabVacina";
            this.tabVacina.Padding = new System.Windows.Forms.Padding(3);
            this.tabVacina.Size = new System.Drawing.Size(846, 383);
            this.tabVacina.TabIndex = 0;
            this.tabVacina.Text = "Dados";
            this.tabVacina.UseVisualStyleBackColor = true;
            // 
            // dgvVacina
            // 
            this.dgvVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacina.Location = new System.Drawing.Point(3, -3);
            this.dgvVacina.Name = "dgvVacina";
            this.dgvVacina.RowHeadersWidth = 51;
            this.dgvVacina.RowTemplate.Height = 24;
            this.dgvVacina.Size = new System.Drawing.Size(847, 383);
            this.dgvVacina.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbxEnfermeiro);
            this.tabPage2.Controls.Add(this.cbxCidade);
            this.tabPage2.Controls.Add(this.cbxGrupoPrioritarioVacina);
            this.tabPage2.Controls.Add(this.cbxComorbidadeVacina);
            this.tabPage2.Controls.Add(this.cbxTipoVacina);
            this.tabPage2.Controls.Add(this.mskbxRgVacina);
            this.tabPage2.Controls.Add(this.mskbxCpfVacina);
            this.tabPage2.Controls.Add(this.dtVacina);
            this.tabPage2.Controls.Add(this.dtNascVacina);
            this.tabPage2.Controls.Add(this.txtEndVacina);
            this.tabPage2.Controls.Add(this.txtNomeVacina);
            this.tabPage2.Controls.Add(this.txtIdVacina);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.Enabled = false;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(593, 203);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(194, 24);
            this.cbxCidade.TabIndex = 24;
            // 
            // cbxGrupoPrioritarioVacina
            // 
            this.cbxGrupoPrioritarioVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrupoPrioritarioVacina.Enabled = false;
            this.cbxGrupoPrioritarioVacina.FormattingEnabled = true;
            this.cbxGrupoPrioritarioVacina.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxGrupoPrioritarioVacina.Location = new System.Drawing.Point(593, 141);
            this.cbxGrupoPrioritarioVacina.Name = "cbxGrupoPrioritarioVacina";
            this.cbxGrupoPrioritarioVacina.Size = new System.Drawing.Size(121, 24);
            this.cbxGrupoPrioritarioVacina.TabIndex = 23;
            // 
            // cbxComorbidadeVacina
            // 
            this.cbxComorbidadeVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComorbidadeVacina.Enabled = false;
            this.cbxComorbidadeVacina.FormattingEnabled = true;
            this.cbxComorbidadeVacina.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxComorbidadeVacina.Location = new System.Drawing.Point(593, 82);
            this.cbxComorbidadeVacina.Name = "cbxComorbidadeVacina";
            this.cbxComorbidadeVacina.Size = new System.Drawing.Size(121, 24);
            this.cbxComorbidadeVacina.TabIndex = 22;
            // 
            // cbxTipoVacina
            // 
            this.cbxTipoVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVacina.FormattingEnabled = true;
            this.cbxTipoVacina.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxTipoVacina.Location = new System.Drawing.Point(593, 29);
            this.cbxTipoVacina.Name = "cbxTipoVacina";
            this.cbxTipoVacina.Size = new System.Drawing.Size(121, 24);
            this.cbxTipoVacina.TabIndex = 21;
            // 
            // mskbxRgVacina
            // 
            this.mskbxRgVacina.Enabled = false;
            this.mskbxRgVacina.Location = new System.Drawing.Point(183, 233);
            this.mskbxRgVacina.Mask = "999999999";
            this.mskbxRgVacina.Name = "mskbxRgVacina";
            this.mskbxRgVacina.Size = new System.Drawing.Size(200, 22);
            this.mskbxRgVacina.TabIndex = 20;
            // 
            // mskbxCpfVacina
            // 
            this.mskbxCpfVacina.Enabled = false;
            this.mskbxCpfVacina.Location = new System.Drawing.Point(183, 188);
            this.mskbxCpfVacina.Mask = "99999999999";
            this.mskbxCpfVacina.Name = "mskbxCpfVacina";
            this.mskbxCpfVacina.Size = new System.Drawing.Size(200, 22);
            this.mskbxCpfVacina.TabIndex = 19;
            // 
            // dtVacina
            // 
            this.dtVacina.CustomFormat = "dd/MM/yyyy";
            this.dtVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVacina.Location = new System.Drawing.Point(184, 280);
            this.dtVacina.Name = "dtVacina";
            this.dtVacina.Size = new System.Drawing.Size(200, 22);
            this.dtVacina.TabIndex = 16;
            // 
            // dtNascVacina
            // 
            this.dtNascVacina.CustomFormat = "dd/MM/yyyy";
            this.dtNascVacina.Enabled = false;
            this.dtNascVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNascVacina.Location = new System.Drawing.Point(184, 102);
            this.dtNascVacina.Name = "dtNascVacina";
            this.dtNascVacina.Size = new System.Drawing.Size(200, 22);
            this.dtNascVacina.TabIndex = 15;
            // 
            // txtEndVacina
            // 
            this.txtEndVacina.Enabled = false;
            this.txtEndVacina.Location = new System.Drawing.Point(183, 143);
            this.txtEndVacina.MaxLength = 100;
            this.txtEndVacina.Name = "txtEndVacina";
            this.txtEndVacina.Size = new System.Drawing.Size(200, 22);
            this.txtEndVacina.TabIndex = 14;
            // 
            // txtNomeVacina
            // 
            this.txtNomeVacina.Enabled = false;
            this.txtNomeVacina.Location = new System.Drawing.Point(183, 63);
            this.txtNomeVacina.MaxLength = 50;
            this.txtNomeVacina.Name = "txtNomeVacina";
            this.txtNomeVacina.Size = new System.Drawing.Size(200, 22);
            this.txtNomeVacina.TabIndex = 13;
            // 
            // txtIdVacina
            // 
            this.txtIdVacina.Enabled = false;
            this.txtIdVacina.Location = new System.Drawing.Point(183, 23);
            this.txtIdVacina.Name = "txtIdVacina";
            this.txtIdVacina.Size = new System.Drawing.Size(100, 22);
            this.txtIdVacina.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(455, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Enfermeiro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(455, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Grupo Prioritário:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Comorbidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo Vacina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data Vacinação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // cbxEnfermeiro
            // 
            this.cbxEnfermeiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnfermeiro.Enabled = false;
            this.cbxEnfermeiro.FormattingEnabled = true;
            this.cbxEnfermeiro.Location = new System.Drawing.Point(593, 264);
            this.cbxEnfermeiro.Name = "cbxEnfermeiro";
            this.cbxEnfermeiro.Size = new System.Drawing.Size(194, 24);
            this.cbxEnfermeiro.TabIndex = 25;
            // 
            // frmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 474);
            this.Controls.Add(this.tbVacina);
            this.Controls.Add(this.bnvVacina);
            this.Name = "frmVacina";
            this.Text = "Cadastro da Vacinação";
            this.Load += new System.EventHandler(this.frmVacina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvVacina)).EndInit();
            this.bnvVacina.ResumeLayout(false);
            this.bnvVacina.PerformLayout();
            this.tbVacina.ResumeLayout(false);
            this.tabVacina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacina)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvVacina;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tbVacina;
        private System.Windows.Forms.TabPage tabVacina;
        private System.Windows.Forms.DataGridView dgvVacina;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ComboBox cbxGrupoPrioritarioVacina;
        private System.Windows.Forms.ComboBox cbxComorbidadeVacina;
        private System.Windows.Forms.ComboBox cbxTipoVacina;
        private System.Windows.Forms.MaskedTextBox mskbxRgVacina;
        private System.Windows.Forms.MaskedTextBox mskbxCpfVacina;
        private System.Windows.Forms.DateTimePicker dtVacina;
        private System.Windows.Forms.DateTimePicker dtNascVacina;
        private System.Windows.Forms.TextBox txtEndVacina;
        private System.Windows.Forms.TextBox txtNomeVacina;
        private System.Windows.Forms.TextBox txtIdVacina;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.ComboBox cbxEnfermeiro;
    }
}