namespace Gestao
{
    partial class frmCadFornecedor
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblDataAttTexto = new System.Windows.Forms.ToolStripLabel();
            this.lblDataValor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblDataCriadoTexto = new System.Windows.Forms.ToolStripLabel();
            this.lblDataCriadoValor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblUsuValor = new System.Windows.Forms.ToolStripLabel();
            this.lblUsuTexto = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDadosFornecedor = new System.Windows.Forms.TabPage();
            this.tabParametrosFornecedor = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDadosFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.toolStrip1.Size = new System.Drawing.Size(591, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "barraFerramentas";
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
            // lblUsuValor
            // 
            this.lblUsuValor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblUsuValor.Name = "lblUsuValor";
            this.lblUsuValor.Size = new System.Drawing.Size(100, 22);
            this.lblUsuValor.Text = "ADMINISTRADOR";
            // 
            // lblUsuTexto
            // 
            this.lblUsuTexto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblUsuTexto.Name = "lblUsuTexto";
            this.lblUsuTexto.Size = new System.Drawing.Size(50, 22);
            this.lblUsuTexto.Text = "Usuário:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDadosFornecedor);
            this.tabControl1.Controls.Add(this.tabParametrosFornecedor);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 468);
            this.tabControl1.TabIndex = 7;
            // 
            // tabDadosFornecedor
            // 
            this.tabDadosFornecedor.Controls.Add(this.pictureBox1);
            this.tabDadosFornecedor.Location = new System.Drawing.Point(4, 24);
            this.tabDadosFornecedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDadosFornecedor.Name = "tabDadosFornecedor";
            this.tabDadosFornecedor.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDadosFornecedor.Size = new System.Drawing.Size(557, 440);
            this.tabDadosFornecedor.TabIndex = 0;
            this.tabDadosFornecedor.Text = "Dados Fornecedor";
            this.tabDadosFornecedor.UseVisualStyleBackColor = true;
            // 
            // tabParametrosFornecedor
            // 
            this.tabParametrosFornecedor.Location = new System.Drawing.Point(4, 24);
            this.tabParametrosFornecedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabParametrosFornecedor.Name = "tabParametrosFornecedor";
            this.tabParametrosFornecedor.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabParametrosFornecedor.Size = new System.Drawing.Size(557, 440);
            this.tabParametrosFornecedor.TabIndex = 1;
            this.tabParametrosFornecedor.Text = "Parametros Fornecedor";
            this.tabParametrosFornecedor.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(432, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 137);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(591, 508);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmCadFornecedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros - Cadastro de Fornecedores";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDadosFornecedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblDataAttTexto;
        private System.Windows.Forms.ToolStripLabel lblDataValor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblDataCriadoTexto;
        private System.Windows.Forms.ToolStripLabel lblDataCriadoValor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblUsuValor;
        private System.Windows.Forms.ToolStripLabel lblUsuTexto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDadosFornecedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabParametrosFornecedor;
    }
}