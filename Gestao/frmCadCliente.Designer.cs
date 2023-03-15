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
            this.guiasCadCli = new System.Windows.Forms.TabControl();
            this.tabDadosCliente = new System.Windows.Forms.TabPage();
            this.grpVazio3 = new System.Windows.Forms.GroupBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.dadosContato = new System.Windows.Forms.DataGridView();
            this.DDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpVazio2 = new System.Windows.Forms.GroupBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
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
            this.grpVazioCob = new System.Windows.Forms.GroupBox();
            this.lblUFCob = new System.Windows.Forms.Label();
            this.cmbUFCob = new System.Windows.Forms.ComboBox();
            this.lblCidadeCob = new System.Windows.Forms.Label();
            this.txtCidadeCob = new System.Windows.Forms.TextBox();
            this.lblBairroCob = new System.Windows.Forms.Label();
            this.txtBairroCob = new System.Windows.Forms.TextBox();
            this.lblCompCob = new System.Windows.Forms.Label();
            this.txtCompCob = new System.Windows.Forms.TextBox();
            this.lblNumCob = new System.Windows.Forms.Label();
            this.txtNumCob = new System.Windows.Forms.TextBox();
            this.lblEndCob = new System.Windows.Forms.Label();
            this.txtEndCob = new System.Windows.Forms.TextBox();
            this.txtCEPCob = new System.Windows.Forms.MaskedTextBox();
            this.btnCEPCob = new System.Windows.Forms.Button();
            this.lblCEPCob = new System.Windows.Forms.Label();
            this.lblDataAttTexto = new System.Windows.Forms.ToolStripLabel();
            this.lblDataValor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblDataCriadoTexto = new System.Windows.Forms.ToolStripLabel();
            this.lblDataCriadoValor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblUsuTexto = new System.Windows.Forms.ToolStripLabel();
            this.lblUsuValor = new System.Windows.Forms.ToolStripLabel();
            this.grpDetalhesOutros = new System.Windows.Forms.GroupBox();
            this.txtObsCliente = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.guiasCadCli.SuspendLayout();
            this.tabDadosCliente.SuspendLayout();
            this.grpVazio3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosContato)).BeginInit();
            this.grpVazio2.SuspendLayout();
            this.grpVazio.SuspendLayout();
            this.tabDadosCobranca.SuspendLayout();
            this.tabOutros.SuspendLayout();
            this.grpVazioCob.SuspendLayout();
            this.grpDetalhesOutros.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDataAttTexto,
            this.lblDataValor,
            this.toolStripSeparator1,
            this.lblDataCriadoTexto,
            this.lblDataCriadoValor,
            this.toolStripSeparator2,
            this.lblUsuValor,
            this.lblUsuTexto});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "barraFerramentas";
            // 
            // guiasCadCli
            // 
            this.guiasCadCli.Controls.Add(this.tabDadosCliente);
            this.guiasCadCli.Controls.Add(this.tabDadosCobranca);
            this.guiasCadCli.Controls.Add(this.tabOutros);
            this.guiasCadCli.HotTrack = true;
            this.guiasCadCli.Location = new System.Drawing.Point(12, 28);
            this.guiasCadCli.Name = "guiasCadCli";
            this.guiasCadCli.SelectedIndex = 0;
            this.guiasCadCli.Size = new System.Drawing.Size(716, 488);
            this.guiasCadCli.TabIndex = 2;
            // 
            // tabDadosCliente
            // 
            this.tabDadosCliente.BackColor = System.Drawing.SystemColors.Control;
            this.tabDadosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDadosCliente.Controls.Add(this.grpVazio3);
            this.tabDadosCliente.Controls.Add(this.grpVazio2);
            this.tabDadosCliente.Controls.Add(this.grpVazio);
            this.tabDadosCliente.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabDadosCliente.Location = new System.Drawing.Point(4, 24);
            this.tabDadosCliente.Name = "tabDadosCliente";
            this.tabDadosCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosCliente.Size = new System.Drawing.Size(708, 460);
            this.tabDadosCliente.TabIndex = 0;
            this.tabDadosCliente.Text = "Dados Cliente";
            // 
            // grpVazio3
            // 
            this.grpVazio3.Controls.Add(this.lblTelefone);
            this.grpVazio3.Controls.Add(this.dadosContato);
            this.grpVazio3.Controls.Add(this.txtDtNasc);
            this.grpVazio3.Controls.Add(this.lblEmail);
            this.grpVazio3.Controls.Add(this.lblDtNasc);
            this.grpVazio3.Controls.Add(this.txtEmail);
            this.grpVazio3.Location = new System.Drawing.Point(6, 313);
            this.grpVazio3.Name = "grpVazio3";
            this.grpVazio3.Padding = new System.Windows.Forms.Padding(2);
            this.grpVazio3.Size = new System.Drawing.Size(696, 141);
            this.grpVazio3.TabIndex = 41;
            this.grpVazio3.TabStop = false;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(482, 16);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 15);
            this.lblTelefone.TabIndex = 44;
            this.lblTelefone.Text = "Telefones";
            // 
            // dadosContato
            // 
            this.dadosContato.AllowUserToOrderColumns = true;
            this.dadosContato.AllowUserToResizeColumns = false;
            this.dadosContato.AllowUserToResizeRows = false;
            this.dadosContato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dadosContato.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dadosContato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dadosContato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dadosContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosContato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DDD,
            this.Telefone});
            this.dadosContato.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dadosContato.Location = new System.Drawing.Point(485, 34);
            this.dadosContato.MultiSelect = false;
            this.dadosContato.Name = "dadosContato";
            this.dadosContato.RowHeadersWidth = 50;
            this.dadosContato.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dadosContato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dadosContato.ShowEditingIcon = false;
            this.dadosContato.Size = new System.Drawing.Size(206, 101);
            this.dadosContato.TabIndex = 5;
            this.dadosContato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosContato_CellContentClick);
            // 
            // DDD
            // 
            this.DDD.FillWeight = 40F;
            this.DDD.HeaderText = "DDD";
            this.DDD.MaxInputLength = 2;
            this.DDD.Name = "DDD";
            this.DDD.Width = 40;
            // 
            // Telefone
            // 
            this.Telefone.FillWeight = 110F;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MaxInputLength = 9;
            this.Telefone.Name = "Telefone";
            this.Telefone.Width = 110;
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Location = new System.Drawing.Point(15, 83);
            this.txtDtNasc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDtNasc.Mask = "00/00/0000";
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(142, 21);
            this.txtDtNasc.TabIndex = 42;
            this.txtDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDtNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 15);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "E-mail";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNasc.Location = new System.Drawing.Point(11, 64);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(85, 15);
            this.lblDtNasc.TabIndex = 41;
            this.lblDtNasc.Text = "Data de Nasc.";
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(14, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(435, 21);
            this.txtEmail.TabIndex = 29;
            // 
            // grpVazio2
            // 
            this.grpVazio2.Controls.Add(this.lblUF);
            this.grpVazio2.Controls.Add(this.comboBox1);
            this.grpVazio2.Controls.Add(this.lblCidade);
            this.grpVazio2.Controls.Add(this.txtCidade);
            this.grpVazio2.Controls.Add(this.lblBairro);
            this.grpVazio2.Controls.Add(this.txtBairro);
            this.grpVazio2.Controls.Add(this.lblComplemento);
            this.grpVazio2.Controls.Add(this.txtComplemento);
            this.grpVazio2.Controls.Add(this.lblNum);
            this.grpVazio2.Controls.Add(this.txtNumero);
            this.grpVazio2.Controls.Add(this.lblEndereco);
            this.grpVazio2.Controls.Add(this.txtEndereco);
            this.grpVazio2.Controls.Add(this.txtCEP);
            this.grpVazio2.Controls.Add(this.btnBuscaCEP);
            this.grpVazio2.Controls.Add(this.lblCEP);
            this.grpVazio2.Location = new System.Drawing.Point(6, 178);
            this.grpVazio2.Name = "grpVazio2";
            this.grpVazio2.Padding = new System.Windows.Forms.Padding(2);
            this.grpVazio2.Size = new System.Drawing.Size(696, 135);
            this.grpVazio2.TabIndex = 29;
            this.grpVazio2.TabStop = false;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(631, 73);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(23, 15);
            this.lblUF.TabIndex = 40;
            this.lblUF.Text = "UF";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBox1.Location = new System.Drawing.Point(634, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 23);
            this.comboBox1.TabIndex = 39;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(427, 73);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 15);
            this.lblCidade.TabIndex = 38;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.AcceptsTab = true;
            this.txtCidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(430, 92);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(197, 21);
            this.txtCidade.TabIndex = 37;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(247, 73);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 15);
            this.lblBairro.TabIndex = 36;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.AcceptsTab = true;
            this.txtBairro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(250, 92);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(174, 21);
            this.txtBairro.TabIndex = 35;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(10, 73);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(86, 15);
            this.lblComplemento.TabIndex = 34;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.AcceptsTab = true;
            this.txtComplemento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(14, 92);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(230, 21);
            this.txtComplemento.TabIndex = 33;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(586, 21);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(52, 15);
            this.lblNum.TabIndex = 32;
            this.lblNum.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.AcceptsTab = true;
            this.txtNumero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(590, 40);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(92, 21);
            this.txtNumero.TabIndex = 31;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(139, 21);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(60, 15);
            this.lblEndereco.TabIndex = 30;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.AcceptsTab = true;
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(143, 40);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(442, 21);
            this.txtEndereco.TabIndex = 29;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(12, 40);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(92, 21);
            this.txtCEP.TabIndex = 18;
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscaCEP
            // 
            this.btnBuscaCEP.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCEP.Location = new System.Drawing.Point(107, 40);
            this.btnBuscaCEP.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscaCEP.Name = "btnBuscaCEP";
            this.btnBuscaCEP.Size = new System.Drawing.Size(20, 20);
            this.btnBuscaCEP.TabIndex = 17;
            this.btnBuscaCEP.Text = "...";
            this.btnBuscaCEP.UseVisualStyleBackColor = true;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(8, 21);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(32, 15);
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
            this.grpVazio.Location = new System.Drawing.Point(6, 6);
            this.grpVazio.Name = "grpVazio";
            this.grpVazio.Padding = new System.Windows.Forms.Padding(2);
            this.grpVazio.Size = new System.Drawing.Size(696, 172);
            this.grpVazio.TabIndex = 15;
            this.grpVazio.TabStop = false;
            // 
            // txtInscMun
            // 
            this.txtInscMun.AcceptsTab = true;
            this.txtInscMun.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscMun.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscMun.Location = new System.Drawing.Point(176, 138);
            this.txtInscMun.Name = "txtInscMun";
            this.txtInscMun.Size = new System.Drawing.Size(137, 21);
            this.txtInscMun.TabIndex = 28;
            this.txtInscMun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInscMun
            // 
            this.lblInscMun.AutoSize = true;
            this.lblInscMun.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscMun.Location = new System.Drawing.Point(171, 118);
            this.lblInscMun.Name = "lblInscMun";
            this.lblInscMun.Size = new System.Drawing.Size(112, 15);
            this.lblInscMun.TabIndex = 27;
            this.lblInscMun.Text = "Inscrição Municipal";
            // 
            // txtInscEst
            // 
            this.txtInscEst.AcceptsTab = true;
            this.txtInscEst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscEst.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscEst.Location = new System.Drawing.Point(13, 138);
            this.txtInscEst.Name = "txtInscEst";
            this.txtInscEst.Size = new System.Drawing.Size(137, 21);
            this.txtInscEst.TabIndex = 26;
            this.txtInscEst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInscEst
            // 
            this.lblInscEst.AutoSize = true;
            this.lblInscEst.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscEst.Location = new System.Drawing.Point(8, 118);
            this.lblInscEst.Name = "lblInscEst";
            this.lblInscEst.Size = new System.Drawing.Size(109, 15);
            this.lblInscEst.TabIndex = 25;
            this.lblInscEst.Text = "Inscrição Estadual";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.AcceptsTab = true;
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(122, 84);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(532, 21);
            this.txtNomeFantasia.TabIndex = 24;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(118, 65);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(92, 15);
            this.lblNomeFantasia.TabIndex = 23;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // flagJuridica
            // 
            this.flagJuridica.AutoSize = true;
            this.flagJuridica.Location = new System.Drawing.Point(11, 90);
            this.flagJuridica.Name = "flagJuridica";
            this.flagJuridica.Size = new System.Drawing.Size(68, 19);
            this.flagJuridica.TabIndex = 22;
            this.flagJuridica.TabStop = true;
            this.flagJuridica.Text = "Jurídica";
            this.flagJuridica.UseVisualStyleBackColor = true;
            // 
            // flagFisica
            // 
            this.flagFisica.AutoSize = true;
            this.flagFisica.Location = new System.Drawing.Point(11, 65);
            this.flagFisica.Name = "flagFisica";
            this.flagFisica.Size = new System.Drawing.Size(58, 19);
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
            this.txtNome.Location = new System.Drawing.Point(221, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(462, 21);
            this.txtNome.TabIndex = 20;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(216, 17);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(116, 15);
            this.lblRazaoSocial.TabIndex = 19;
            this.lblRazaoSocial.Text = "Nome/Razão Social";
            // 
            // lblCNPJ_CPF
            // 
            this.lblCNPJ_CPF.AutoSize = true;
            this.lblCNPJ_CPF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ_CPF.Location = new System.Drawing.Point(82, 17);
            this.lblCNPJ_CPF.Name = "lblCNPJ_CPF";
            this.lblCNPJ_CPF.Size = new System.Drawing.Size(66, 15);
            this.lblCNPJ_CPF.TabIndex = 18;
            this.lblCNPJ_CPF.Text = "CNPJ/CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.AcceptsTab = true;
            this.txtCPF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(87, 36);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(123, 21);
            this.txtCPF.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AcceptsTab = true;
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(13, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(64, 21);
            this.txtCodigo.TabIndex = 16;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 17);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(47, 15);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código";
            // 
            // tabDadosCobranca
            // 
            this.tabDadosCobranca.BackColor = System.Drawing.SystemColors.Control;
            this.tabDadosCobranca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDadosCobranca.Controls.Add(this.grpVazioCob);
            this.tabDadosCobranca.Location = new System.Drawing.Point(4, 24);
            this.tabDadosCobranca.Name = "tabDadosCobranca";
            this.tabDadosCobranca.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosCobranca.Size = new System.Drawing.Size(708, 460);
            this.tabDadosCobranca.TabIndex = 1;
            this.tabDadosCobranca.Text = "Dados Cobrança";
            // 
            // tabOutros
            // 
            this.tabOutros.BackColor = System.Drawing.SystemColors.Control;
            this.tabOutros.Controls.Add(this.grpDetalhesOutros);
            this.tabOutros.Location = new System.Drawing.Point(4, 24);
            this.tabOutros.Name = "tabOutros";
            this.tabOutros.Size = new System.Drawing.Size(708, 460);
            this.tabOutros.TabIndex = 2;
            this.tabOutros.Text = "Outras Informações";
            // 
            // grpVazioCob
            // 
            this.grpVazioCob.Controls.Add(this.lblUFCob);
            this.grpVazioCob.Controls.Add(this.cmbUFCob);
            this.grpVazioCob.Controls.Add(this.lblCidadeCob);
            this.grpVazioCob.Controls.Add(this.txtCidadeCob);
            this.grpVazioCob.Controls.Add(this.lblBairroCob);
            this.grpVazioCob.Controls.Add(this.txtBairroCob);
            this.grpVazioCob.Controls.Add(this.lblCompCob);
            this.grpVazioCob.Controls.Add(this.txtCompCob);
            this.grpVazioCob.Controls.Add(this.lblNumCob);
            this.grpVazioCob.Controls.Add(this.txtNumCob);
            this.grpVazioCob.Controls.Add(this.lblEndCob);
            this.grpVazioCob.Controls.Add(this.txtEndCob);
            this.grpVazioCob.Controls.Add(this.txtCEPCob);
            this.grpVazioCob.Controls.Add(this.btnCEPCob);
            this.grpVazioCob.Controls.Add(this.lblCEPCob);
            this.grpVazioCob.Location = new System.Drawing.Point(6, 6);
            this.grpVazioCob.Name = "grpVazioCob";
            this.grpVazioCob.Padding = new System.Windows.Forms.Padding(2);
            this.grpVazioCob.Size = new System.Drawing.Size(696, 135);
            this.grpVazioCob.TabIndex = 30;
            this.grpVazioCob.TabStop = false;
            this.grpVazioCob.Text = "Endereço de Cobrança";
            // 
            // lblUFCob
            // 
            this.lblUFCob.AutoSize = true;
            this.lblUFCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFCob.Location = new System.Drawing.Point(631, 73);
            this.lblUFCob.Name = "lblUFCob";
            this.lblUFCob.Size = new System.Drawing.Size(23, 15);
            this.lblUFCob.TabIndex = 40;
            this.lblUFCob.Text = "UF";
            // 
            // cmbUFCob
            // 
            this.cmbUFCob.FormattingEnabled = true;
            this.cmbUFCob.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbUFCob.Location = new System.Drawing.Point(634, 91);
            this.cmbUFCob.Name = "cmbUFCob";
            this.cmbUFCob.Size = new System.Drawing.Size(49, 23);
            this.cmbUFCob.TabIndex = 39;
            // 
            // lblCidadeCob
            // 
            this.lblCidadeCob.AutoSize = true;
            this.lblCidadeCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeCob.Location = new System.Drawing.Point(427, 73);
            this.lblCidadeCob.Name = "lblCidadeCob";
            this.lblCidadeCob.Size = new System.Drawing.Size(47, 15);
            this.lblCidadeCob.TabIndex = 38;
            this.lblCidadeCob.Text = "Cidade";
            // 
            // txtCidadeCob
            // 
            this.txtCidadeCob.AcceptsTab = true;
            this.txtCidadeCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCob.Location = new System.Drawing.Point(430, 92);
            this.txtCidadeCob.Name = "txtCidadeCob";
            this.txtCidadeCob.Size = new System.Drawing.Size(197, 21);
            this.txtCidadeCob.TabIndex = 37;
            // 
            // lblBairroCob
            // 
            this.lblBairroCob.AutoSize = true;
            this.lblBairroCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroCob.Location = new System.Drawing.Point(247, 73);
            this.lblBairroCob.Name = "lblBairroCob";
            this.lblBairroCob.Size = new System.Drawing.Size(40, 15);
            this.lblBairroCob.TabIndex = 36;
            this.lblBairroCob.Text = "Bairro";
            // 
            // txtBairroCob
            // 
            this.txtBairroCob.AcceptsTab = true;
            this.txtBairroCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCob.Location = new System.Drawing.Point(250, 92);
            this.txtBairroCob.Name = "txtBairroCob";
            this.txtBairroCob.Size = new System.Drawing.Size(174, 21);
            this.txtBairroCob.TabIndex = 35;
            // 
            // lblCompCob
            // 
            this.lblCompCob.AutoSize = true;
            this.lblCompCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompCob.Location = new System.Drawing.Point(10, 73);
            this.lblCompCob.Name = "lblCompCob";
            this.lblCompCob.Size = new System.Drawing.Size(86, 15);
            this.lblCompCob.TabIndex = 34;
            this.lblCompCob.Text = "Complemento";
            // 
            // txtCompCob
            // 
            this.txtCompCob.AcceptsTab = true;
            this.txtCompCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompCob.Location = new System.Drawing.Point(14, 92);
            this.txtCompCob.Name = "txtCompCob";
            this.txtCompCob.Size = new System.Drawing.Size(230, 21);
            this.txtCompCob.TabIndex = 33;
            // 
            // lblNumCob
            // 
            this.lblNumCob.AutoSize = true;
            this.lblNumCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCob.Location = new System.Drawing.Point(586, 21);
            this.lblNumCob.Name = "lblNumCob";
            this.lblNumCob.Size = new System.Drawing.Size(52, 15);
            this.lblNumCob.TabIndex = 32;
            this.lblNumCob.Text = "Número";
            // 
            // txtNumCob
            // 
            this.txtNumCob.AcceptsTab = true;
            this.txtNumCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCob.Location = new System.Drawing.Point(590, 40);
            this.txtNumCob.Name = "txtNumCob";
            this.txtNumCob.Size = new System.Drawing.Size(92, 21);
            this.txtNumCob.TabIndex = 31;
            this.txtNumCob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEndCob
            // 
            this.lblEndCob.AutoSize = true;
            this.lblEndCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndCob.Location = new System.Drawing.Point(139, 21);
            this.lblEndCob.Name = "lblEndCob";
            this.lblEndCob.Size = new System.Drawing.Size(60, 15);
            this.lblEndCob.TabIndex = 30;
            this.lblEndCob.Text = "Endereço";
            // 
            // txtEndCob
            // 
            this.txtEndCob.AcceptsTab = true;
            this.txtEndCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndCob.Location = new System.Drawing.Point(143, 40);
            this.txtEndCob.Name = "txtEndCob";
            this.txtEndCob.Size = new System.Drawing.Size(442, 21);
            this.txtEndCob.TabIndex = 29;
            // 
            // txtCEPCob
            // 
            this.txtCEPCob.Location = new System.Drawing.Point(12, 40);
            this.txtCEPCob.Margin = new System.Windows.Forms.Padding(2);
            this.txtCEPCob.Mask = "00000-999";
            this.txtCEPCob.Name = "txtCEPCob";
            this.txtCEPCob.Size = new System.Drawing.Size(92, 21);
            this.txtCEPCob.TabIndex = 18;
            this.txtCEPCob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCEPCob
            // 
            this.btnCEPCob.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCEPCob.Location = new System.Drawing.Point(107, 40);
            this.btnCEPCob.Margin = new System.Windows.Forms.Padding(2);
            this.btnCEPCob.Name = "btnCEPCob";
            this.btnCEPCob.Size = new System.Drawing.Size(20, 20);
            this.btnCEPCob.TabIndex = 17;
            this.btnCEPCob.Text = "...";
            this.btnCEPCob.UseVisualStyleBackColor = true;
            // 
            // lblCEPCob
            // 
            this.lblCEPCob.AutoSize = true;
            this.lblCEPCob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEPCob.Location = new System.Drawing.Point(8, 21);
            this.lblCEPCob.Name = "lblCEPCob";
            this.lblCEPCob.Size = new System.Drawing.Size(32, 15);
            this.lblCEPCob.TabIndex = 15;
            this.lblCEPCob.Text = "CEP";
            // 
            // lblDataAttTexto
            // 
            this.lblDataAttTexto.Name = "lblDataAttTexto";
            this.lblDataAttTexto.Size = new System.Drawing.Size(66, 22);
            this.lblDataAttTexto.Text = "Atualizado:";
            // 
            // lblDataValor
            // 
            this.lblDataValor.Name = "lblDataValor";
            this.lblDataValor.Size = new System.Drawing.Size(65, 22);
            this.lblDataValor.Text = "01/01/1900";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblDataCriadoTexto
            // 
            this.lblDataCriadoTexto.Name = "lblDataCriadoTexto";
            this.lblDataCriadoTexto.Size = new System.Drawing.Size(65, 22);
            this.lblDataCriadoTexto.Text = "Criado em:";
            // 
            // lblDataCriadoValor
            // 
            this.lblDataCriadoValor.Name = "lblDataCriadoValor";
            this.lblDataCriadoValor.Size = new System.Drawing.Size(65, 22);
            this.lblDataCriadoValor.Text = "01/01/1900";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblUsuTexto
            // 
            this.lblUsuTexto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblUsuTexto.Name = "lblUsuTexto";
            this.lblUsuTexto.Size = new System.Drawing.Size(50, 22);
            this.lblUsuTexto.Text = "Usuário:";
            // 
            // lblUsuValor
            // 
            this.lblUsuValor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblUsuValor.Name = "lblUsuValor";
            this.lblUsuValor.Size = new System.Drawing.Size(100, 22);
            this.lblUsuValor.Text = "ADMINISTRADOR";
            // 
            // grpDetalhesOutros
            // 
            this.grpDetalhesOutros.Controls.Add(this.txtObsCliente);
            this.grpDetalhesOutros.Location = new System.Drawing.Point(3, 3);
            this.grpDetalhesOutros.Name = "grpDetalhesOutros";
            this.grpDetalhesOutros.Size = new System.Drawing.Size(702, 454);
            this.grpDetalhesOutros.TabIndex = 0;
            this.grpDetalhesOutros.TabStop = false;
            this.grpDetalhesOutros.Text = "Observações do Cliente";
            // 
            // txtObsCliente
            // 
            this.txtObsCliente.Location = new System.Drawing.Point(6, 20);
            this.txtObsCliente.Multiline = true;
            this.txtObsCliente.Name = "txtObsCliente";
            this.txtObsCliente.Size = new System.Drawing.Size(690, 197);
            this.txtObsCliente.TabIndex = 0;
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
            this.grpVazio3.ResumeLayout(false);
            this.grpVazio3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosContato)).EndInit();
            this.grpVazio2.ResumeLayout(false);
            this.grpVazio2.PerformLayout();
            this.grpVazio.ResumeLayout(false);
            this.grpVazio.PerformLayout();
            this.tabDadosCobranca.ResumeLayout(false);
            this.tabOutros.ResumeLayout(false);
            this.grpVazioCob.ResumeLayout(false);
            this.grpVazioCob.PerformLayout();
            this.grpDetalhesOutros.ResumeLayout(false);
            this.grpDetalhesOutros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStrip1;
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
        private System.Windows.Forms.GroupBox grpVazio2;
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
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.GroupBox grpVazio3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtDtNasc;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.DataGridView dadosContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.ToolStripLabel lblDataAttTexto;
        private System.Windows.Forms.ToolStripLabel lblDataValor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblDataCriadoTexto;
        private System.Windows.Forms.ToolStripLabel lblDataCriadoValor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblUsuValor;
        private System.Windows.Forms.ToolStripLabel lblUsuTexto;
        private System.Windows.Forms.GroupBox grpVazioCob;
        private System.Windows.Forms.Label lblUFCob;
        private System.Windows.Forms.ComboBox cmbUFCob;
        private System.Windows.Forms.Label lblCidadeCob;
        private System.Windows.Forms.TextBox txtCidadeCob;
        private System.Windows.Forms.Label lblBairroCob;
        private System.Windows.Forms.TextBox txtBairroCob;
        private System.Windows.Forms.Label lblCompCob;
        private System.Windows.Forms.TextBox txtCompCob;
        private System.Windows.Forms.Label lblNumCob;
        private System.Windows.Forms.TextBox txtNumCob;
        private System.Windows.Forms.Label lblEndCob;
        private System.Windows.Forms.TextBox txtEndCob;
        private System.Windows.Forms.MaskedTextBox txtCEPCob;
        private System.Windows.Forms.Button btnCEPCob;
        private System.Windows.Forms.Label lblCEPCob;
        private System.Windows.Forms.GroupBox grpDetalhesOutros;
        private System.Windows.Forms.TextBox txtObsCliente;
    }
}