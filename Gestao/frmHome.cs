using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Gestao
{

    public partial class frmHome : Form
    {
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("X.X.X.X");
        }

        string hostName = System.Net.Dns.GetHostName();


        public frmHome()
        {
            String versaoBD = "1.0.0";
            String versaoApp = "ALPHA-1.0.0";
            InitializeComponent();
            lblIPAddr.Text = GetLocalIPAddress();
            lblHost.Text = hostName;
            lblVersaoBD.Text = versaoBD;
            lblVersao.Text = versaoApp.ToString();
            verificaLogin();

        }

        private void closeChildForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void showFrm(Form frm)
        {
            frm.Show();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void verificaLogin()
        {
            Boolean bolLogado = false;
            if (!bolLogado)
            {
                Form login = new frmLogin();
                showFrm(login);
            }
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCadCliente();
            frm.MdiParent = this;
            showFrm(frm);

        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            {
                foreach (Control control in this.Controls)
                {
                    if (control is MdiClient)
                    {
                        control.BackColor = System.Drawing.ColorTranslator.FromHtml("#80ACFF"); ;
                        break;
                    }
                }
                IsMdiContainer = true;
                var sideBar = new Form();
                sideBar.Text = "SideBar";
                sideBar.TopLevel = false;
                sideBar.FormBorderStyle = FormBorderStyle.None;
                sideBar.Dock = DockStyle.Right;
                sideBar.MaximizeBox = false;
                    
                this.Controls.Add(sideBar);


                sideBar.Show();

            }
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCadFornecedor();
            frm.MdiParent = this;
            showFrm(frm);
        }
    }
}
