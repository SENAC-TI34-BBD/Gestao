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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscaCEP = new System.Windows.Forms.Button();
            this.lblCEP = new System.Windows.Forms.Label();
            this.grpVazio = new System.Windows.Forms.GroupBox();
            this.txtInscMun = new System.Windows.Forms.TextBox();
            this.lblInscMun = new System.Windows.Forms.Label();
            this.txtInscEst = new System.Windows.Forms.TextBox();
            this.lblInscEst = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.flagJuridica = new System.Windows.Forms.RadioButton();
            this.flagFisica = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblCNPJ_CPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabDadosCobranca = new System.Windows.Forms.TabPage();
            this.tabOutros = new System.Windows.Forms.TabPage();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.guiasCadCli.SuspendLayout();
            this.tabDadosCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpVazio.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.salvarToolStripButton,
            this.toolStripSeparator,
            this.imprimirToolStripButton,
            this.toolStripSeparator1,
            this.excluirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStrip1.Size = new System.Drawing.Size(925, 31);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "barraFerramentas";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = global::Gestao.Properties.Resources.iconAdd;
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.novoToolStripButton.Text = "Novo";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = global::Gestao.Properties.Resources.iconSave;
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.salvarToolStripButton.Text = "Salvar";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = global::Gestao.Properties.Resources.iconPrint;
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.imprimirToolStripButton.Text = "Imprimir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // excluirToolStripButton
            // 
            this.excluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.excluirToolStripButton.Image = global::Gestao.Properties.Resources.iconDelete;
            this.excluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirToolStripButton.Name = "excluirToolStripButton";
            this.excluirToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.excluirToolStripButton.Text = "Excluir";
            // 
            // guiasCadCli
            // 
            this.guiasCadCli.Controls.Add(this.tabDadosCliente);
            this.guiasCadCli.Controls.Add(this.tabDadosCobranca);
            this.guiasCadCli.Controls.Add(this.tabOutros);
            this.guiasCadCli.HotTrack = true;
            this.guiasCadCli.Location = new System.Drawing.Point(15, 35);
            this.guiasCadCli.Margin = new System.Windows.Forms.Padding(4);
            this.guiasCadCli.Name = "guiasCadCli";
            this.guiasCadCli.SelectedIndex = 0;
            this.guiasCadCli.Size = new System.Drawing.Size(895, 610);
            this.guiasCadCli.TabIndex = 2;
            // 
            // tabDadosCliente
            // 
            this.tabDadosCliente.BackColor = System.Drawing.SystemColors.Control;
            this.tabDadosCliente.Controls.Add(this.groupBox1);
            this.tabDadosCliente.Controls.Add(this.grpVazio);
            this.tabDadosCliente.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabDadosCliente.Location = new System.Drawing.Point(4, 26);
            this.tabDadosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tabDadosCliente.Name = "tabDadosCliente";
            this.tabDadosCliente.Padding = new System.Windows.Forms.Padding(4);
            this.tabDadosCliente.Size = new System.Drawing.Size(887, 580);
            this.tabDadosCliente.TabIndex = 0;
            this.tabDadosCliente.Text = "Dados Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNum);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.btnBuscaCEP);
            this.groupBox1.Controls.Add(this.lblCEP);
            this.groupBox1.Location = new System.Drawing.Point(8, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(870, 190);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(174, 26);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(71, 17);
            this.lblEndereco.TabIndex = 30;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.AcceptsTab = true;
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(179, 50);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(551, 25);
            this.txtEndereco.TabIndex = 29;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(15, 50);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(114, 25);
            this.txtCEP.TabIndex = 18;
            // 
            // btnBuscaCEP
            // 
            this.btnBuscaCEP.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCEP.Location = new System.Drawing.Point(134, 50);
            this.btnBuscaCEP.Name = "btnBuscaCEP";
            this.btnBuscaCEP.Size = new System.Drawing.Size(25, 25);
            this.btnBuscaCEP.TabIndex = 17;
            this.btnBuscaCEP.Text = "...";
            this.btnBuscaCEP.UseVisualStyleBackColor = true;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(10, 26);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(39, 17);
            this.lblCEP.TabIndex = 15;
            this.lblCEP.Text = "CEP";
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
            this.grpVazio.Location = new System.Drawing.Point(8, 8);
            this.grpVazio.Margin = new System.Windows.Forms.Padding(4);
            this.grpVazio.Name = "grpVazio";
            this.grpVazio.Padding = new System.Windows.Forms.Padding(2);
            this.grpVazio.Size = new System.Drawing.Size(870, 215);
            this.grpVazio.TabIndex = 15;
            this.grpVazio.TabStop = false;
            // 
            // txtInscMun
            // 
            this.txtInscMun.AcceptsTab = true;
            this.txtInscMun.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscMun.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscMun.Location = new System.Drawing.Point(220, 169);
            this.txtInscMun.Margin = new System.Windows.Forms.Padding(4);
            this.txtInscMun.Name = "txtInscMun";
            this.txtInscMun.Size = new System.Drawing.Size(170, 25);
            this.txtInscMun.TabIndex = 28;
            // 
            // lblInscMun
            // 
            this.lblInscMun.AutoSize = true;
            this.lblInscMun.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscMun.Location = new System.Drawing.Point(214, 144);
            this.lblInscMun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInscMun.Name = "lblInscMun";
            this.lblInscMun.Size = new System.Drawing.Size(131, 17);
            this.lblInscMun.TabIndex = 27;
            this.lblInscMun.Text = "Inscrição Municipal";
            // 
            // txtInscEst
            // 
            this.txtInscEst.AcceptsTab = true;
            this.txtInscEst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscEst.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscEst.Location = new System.Drawing.Point(16, 169);
            this.txtInscEst.Margin = new System.Windows.Forms.Padding(4);
            this.txtInscEst.Name = "txtInscEst";
            this.txtInscEst.Size = new System.Drawing.Size(170, 25);
            this.txtInscEst.TabIndex = 26;
            // 
            // lblInscEst
            // 
            this.lblInscEst.AutoSize = true;
            this.lblInscEst.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscEst.Location = new System.Drawing.Point(10, 144);
            this.lblInscEst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInscEst.Name = "lblInscEst";
            this.lblInscEst.Size = new System.Drawing.Size(128, 17);
            this.lblInscEst.TabIndex = 25;
            this.lblInscEst.Text = "Inscrição Estadual";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.AcceptsTab = true;
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(152, 110);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(652, 25);
            this.txtNomeFantasia.TabIndex = 24;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(147, 86);
            this.lblNomeFantasia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(107, 17);
            this.lblNomeFantasia.TabIndex = 23;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // flagJuridica
            // 
            this.flagJuridica.AutoSize = true;
            this.flagJuridica.Location = new System.Drawing.Point(14, 117);
            this.flagJuridica.Margin = new System.Windows.Forms.Padding(4);
            this.flagJuridica.Name = "flagJuridica";
            this.flagJuridica.Size = new System.Drawing.Size(79, 21);
            this.flagJuridica.TabIndex = 22;
            this.flagJuridica.TabStop = true;
            this.flagJuridica.Text = "Jurídica";
            this.flagJuridica.UseVisualStyleBackColor = true;
            // 
            // flagFisica
            // 
            this.flagFisica.AutoSize = true;
            this.flagFisica.Location = new System.Drawing.Point(14, 86);
            this.flagFisica.Margin = new System.Windows.Forms.Padding(4);
            this.flagFisica.Name = "flagFisica";
            this.flagFisica.Size = new System.Drawing.Size(68, 21);
            this.flagFisica.TabIndex = 21;
            this.flagFisica.TabStop = true;
            this.flagFisica.Text = "Física";
            this.flagFisica.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.AcceptsTab = true;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(276, 50);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(576, 25);
            this.txtNome.TabIndex = 20;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(270, 26);
            this.lblRazaoSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(138, 17);
            this.lblRazaoSocial.TabIndex = 19;
            this.lblRazaoSocial.Text = "Nome/Razão Social";
            // 
            // lblCNPJ_CPF
            // 
            this.lblCNPJ_CPF.AutoSize = true;
            this.lblCNPJ_CPF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ_CPF.Location = new System.Drawing.Point(103, 26);
            this.lblCNPJ_CPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCNPJ_CPF.Name = "lblCNPJ_CPF";
            this.lblCNPJ_CPF.Size = new System.Drawing.Size(80, 17);
            this.lblCNPJ_CPF.TabIndex = 18;
            this.lblCNPJ_CPF.Text = "CNPJ/CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.AcceptsTab = true;
            this.txtCPF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(109, 50);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(153, 25);
            this.txtCPF.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AcceptsTab = true;
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(16, 50);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 25);
            this.txtCodigo.TabIndex = 16;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(10, 26);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 17);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código";
            // 
            // tabDadosCobranca
            // 
            this.tabDadosCobranca.Location = new System.Drawing.Point(4, 26);
            this.tabDadosCobranca.Margin = new System.Windows.Forms.Padding(4);
            this.tabDadosCobranca.Name = "tabDadosCobranca";
            this.tabDadosCobranca.Padding = new System.Windows.Forms.Padding(4);
            this.tabDadosCobranca.Size = new System.Drawing.Size(887, 580);
            this.tabDadosCobranca.TabIndex = 1;
            this.tabDadosCobranca.Text = "Dados Cobrança";
            this.tabDadosCobranca.UseVisualStyleBackColor = true;
            // 
            // tabOutros
            // 
            this.tabOutros.Location = new System.Drawing.Point(4, 26);
            this.tabOutros.Margin = new System.Windows.Forms.Padding(4);
            this.tabOutros.Name = "tabOutros";
            this.tabOutros.Size = new System.Drawing.Size(887, 580);
            this.tabOutros.TabIndex = 2;
            this.tabOutros.Text = "Outras Informações";
            this.tabOutros.UseVisualStyleBackColor = true;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(733, 26);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(60, 17);
            this.lblNum.TabIndex = 32;
            this.lblNum.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.AcceptsTab = true;
            this.txtNumero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(738, 50);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(114, 25);
            this.txtNumero.TabIndex = 31;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(925, 660);
            this.Controls.Add(this.guiasCadCli);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpVazio.ResumeLayout(false);
            this.grpVazio.PerformLayout();
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
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtInscMun;
        private System.Windows.Forms.Label lblInscMun;
        private System.Windows.Forms.TextBox txtInscEst;
        private System.Windows.Forms.Label lblInscEst;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Button btnBuscaCEP;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNumero;
    }
}