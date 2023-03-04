namespace Gestao
{
    partial class frmCadCliente
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.guiasCadCli = new System.Windows.Forms.TabControl();
            this.tabDadosCliente = new System.Windows.Forms.TabPage();
            this.tabDadosCobranca = new System.Windows.Forms.TabPage();
            this.tabOutros = new System.Windows.Forms.TabPage();
            this.grpVazio = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblCNPJ_CPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.flagFisica = new System.Windows.Forms.RadioButton();
            this.flagJuridica = new System.Windows.Forms.RadioButton();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtInscEst = new System.Windows.Forms.TextBox();
            this.lblInscEst = new System.Windows.Forms.Label();
            this.txtInscMun = new System.Windows.Forms.TextBox();
            this.lblInscMun = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.guiasCadCli.SuspendLayout();
            this.tabDadosCliente.SuspendLayout();
            this.grpVazio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.salvarToolStripButton,
            this.toolStripSeparator,
            this.imprimirToolStripButton,
            this.toolStripSeparator1,
            this.excluirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "barraFerramentas";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = global::Gestao.Properties.Resources.iconAdd;
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.novoToolStripButton.Text = "Novo";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = global::Gestao.Properties.Resources.iconSave;
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "Salvar";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = global::Gestao.Properties.Resources.iconPrint;
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimirToolStripButton.Text = "Imprimir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // excluirToolStripButton
            // 
            this.excluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.excluirToolStripButton.Image = global::Gestao.Properties.Resources.iconDelete;
            this.excluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirToolStripButton.Name = "excluirToolStripButton";
            this.excluirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.excluirToolStripButton.Text = "Excluir";
            // 
            // guiasCadCli
            // 
            this.guiasCadCli.Controls.Add(this.tabDadosCliente);
            this.guiasCadCli.Controls.Add(this.tabDadosCobranca);
            this.guiasCadCli.Controls.Add(this.tabOutros);
            this.guiasCadCli.Location = new System.Drawing.Point(12, 28);
            this.guiasCadCli.Name = "guiasCadCli";
            this.guiasCadCli.SelectedIndex = 0;
            this.guiasCadCli.Size = new System.Drawing.Size(716, 488);
            this.guiasCadCli.TabIndex = 2;
            // 
            // tabDadosCliente
            // 
            this.tabDadosCliente.BackColor = System.Drawing.SystemColors.Control;
            this.tabDadosCliente.Controls.Add(this.groupBox1);
            this.tabDadosCliente.Controls.Add(this.grpVazio);
            this.tabDadosCliente.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabDadosCliente.Location = new System.Drawing.Point(4, 24);
            this.tabDadosCliente.Name = "tabDadosCliente";
            this.tabDadosCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosCliente.Size = new System.Drawing.Size(708, 460);
            this.tabDadosCliente.TabIndex = 0;
            this.tabDadosCliente.Text = "Dados Cliente";
            // 
            // tabDadosCobranca
            // 
            this.tabDadosCobranca.Location = new System.Drawing.Point(4, 24);
            this.tabDadosCobranca.Name = "tabDadosCobranca";
            this.tabDadosCobranca.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosCobranca.Size = new System.Drawing.Size(708, 460);
            this.tabDadosCobranca.TabIndex = 1;
            this.tabDadosCobranca.Text = "Dados Cobrança";
            this.tabDadosCobranca.UseVisualStyleBackColor = true;
            // 
            // tabOutros
            // 
            this.tabOutros.Location = new System.Drawing.Point(4, 24);
            this.tabOutros.Name = "tabOutros";
            this.tabOutros.Size = new System.Drawing.Size(708, 460);
            this.tabOutros.TabIndex = 2;
            this.tabOutros.Text = "Outras Informações";
            this.tabOutros.UseVisualStyleBackColor = true;
            // 
            // grpVazio
            // 
            this.grpVazio.Controls.Add(this.txtInscMun);
            this.grpVazio.Controls.Add(this.lblInscMun);
            this.grpVazio.Controls.Add(this.txtInscEst);
            this.grpVazio.Controls.Add(this.lblInscEst);
            this.grpVazio.Controls.Add(this.txtNomeFantasia);
            this.grpVazio.Controls.Add(this.lblNomeFantasia);
            this.grpVazio.Controls.Add(this.flagJuridica);
            this.grpVazio.Controls.Add(this.flagFisica);
            this.grpVazio.Controls.Add(this.txtNome);
            this.grpVazio.Controls.Add(this.lblRazaoSocial);
            this.grpVazio.Controls.Add(this.lblCNPJ_CPF);
            this.grpVazio.Controls.Add(this.txtCPF);
            this.grpVazio.Controls.Add(this.txtCodigo);
            this.grpVazio.Controls.Add(this.lblCodigo);
            this.grpVazio.Location = new System.Drawing.Point(6, 6);
            this.grpVazio.Name = "grpVazio";
            this.grpVazio.Size = new System.Drawing.Size(696, 172);
            this.grpVazio.TabIndex = 15;
            this.grpVazio.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.AcceptsTab = true;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(221, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(462, 21);
            this.txtNome.TabIndex = 20;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(218, 22);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(116, 15);
            this.lblRazaoSocial.TabIndex = 19;
            this.lblRazaoSocial.Text = "Nome/Razão Social";
            // 
            // lblCNPJ_CPF
            // 
            this.lblCNPJ_CPF.AutoSize = true;
            this.lblCNPJ_CPF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ_CPF.Location = new System.Drawing.Point(84, 22);
            this.lblCNPJ_CPF.Name = "lblCNPJ_CPF";
            this.lblCNPJ_CPF.Size = new System.Drawing.Size(66, 15);
            this.lblCNPJ_CPF.TabIndex = 18;
            this.lblCNPJ_CPF.Text = "CNPJ/CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.AcceptsTab = true;
            this.txtCPF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(87, 40);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(123, 21);
            this.txtCPF.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AcceptsTab = true;
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(13, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(64, 21);
            this.txtCodigo.TabIndex = 16;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(10, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(47, 15);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código";
            // 
            // flagFisica
            // 
            this.flagFisica.AutoSize = true;
            this.flagFisica.Location = new System.Drawing.Point(13, 70);
            this.flagFisica.Name = "flagFisica";
            this.flagFisica.Size = new System.Drawing.Size(58, 19);
            this.flagFisica.TabIndex = 21;
            this.flagFisica.TabStop = true;
            this.flagFisica.Text = "Física";
            this.flagFisica.UseVisualStyleBackColor = true;
            this.flagFisica.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // flagJuridica
            // 
            this.flagJuridica.AutoSize = true;
            this.flagJuridica.Location = new System.Drawing.Point(13, 95);
            this.flagJuridica.Name = "flagJuridica";
            this.flagJuridica.Size = new System.Drawing.Size(68, 19);
            this.flagJuridica.TabIndex = 22;
            this.flagJuridica.TabStop = true;
            this.flagJuridica.Text = "Jurídica";
            this.flagJuridica.UseVisualStyleBackColor = true;
            this.flagJuridica.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.AcceptsTab = true;
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(122, 88);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(522, 21);
            this.txtNomeFantasia.TabIndex = 24;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(119, 70);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(92, 15);
            this.lblNomeFantasia.TabIndex = 23;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // txtInscEst
            // 
            this.txtInscEst.AcceptsTab = true;
            this.txtInscEst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscEst.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscEst.Location = new System.Drawing.Point(13, 135);
            this.txtInscEst.Name = "txtInscEst";
            this.txtInscEst.Size = new System.Drawing.Size(137, 21);
            this.txtInscEst.TabIndex = 26;
            // 
            // lblInscEst
            // 
            this.lblInscEst.AutoSize = true;
            this.lblInscEst.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscEst.Location = new System.Drawing.Point(10, 117);
            this.lblInscEst.Name = "lblInscEst";
            this.lblInscEst.Size = new System.Drawing.Size(109, 15);
            this.lblInscEst.TabIndex = 25;
            this.lblInscEst.Text = "Inscrição Estadual";
            // 
            // txtInscMun
            // 
            this.txtInscMun.AcceptsTab = true;
            this.txtInscMun.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscMun.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscMun.Location = new System.Drawing.Point(176, 135);
            this.txtInscMun.Name = "txtInscMun";
            this.txtInscMun.Size = new System.Drawing.Size(137, 21);
            this.txtInscMun.TabIndex = 28;
            // 
            // lblInscMun
            // 
            this.lblInscMun.AutoSize = true;
            this.lblInscMun.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscMun.Location = new System.Drawing.Point(173, 117);
            this.lblInscMun.Name = "lblInscMun";
            this.lblInscMun.Size = new System.Drawing.Size(112, 15);
            this.lblInscMun.TabIndex = 27;
            this.lblInscMun.Text = "Inscrição Municipal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.lblCEP);
            this.groupBox1.Location = new System.Drawing.Point(6, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 172);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // txtCEP
            // 
            this.txtCEP.AcceptsTab = true;
            this.txtCEP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(13, 40);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(91, 21);
            this.txtCEP.TabIndex = 16;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(10, 22);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(32, 15);
            this.lblCEP.TabIndex = 15;
            this.lblCEP.Text = "CEP";
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(740, 528);
            this.Controls.Add(this.guiasCadCli);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros - Cadastro de Cliente";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.guiasCadCli.ResumeLayout(false);
            this.tabDadosCliente.ResumeLayout(false);
            this.grpVazio.ResumeLayout(false);
            this.grpVazio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.ToolStripButton excluirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl guiasCadCli;
        private System.Windows.Forms.TabPage tabDadosCliente;
        private System.Windows.Forms.TabPage tabDadosCobranca;
        private System.Windows.Forms.TabPage tabOutros;
        private System.Windows.Forms.GroupBox grpVazio;
        private System.Windows.Forms.RadioButton flagJuridica;
        private System.Windows.Forms.RadioButton flagFisica;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblCNPJ_CPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtInscMun;
        private System.Windows.Forms.Label lblInscMun;
        private System.Windows.Forms.TextBox txtInscEst;
        private System.Windows.Forms.Label lblInscEst;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
    }
}