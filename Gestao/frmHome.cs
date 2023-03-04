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


        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForm();
            Form frm = new frmCadCliente();
            showFrm(frm);
        }

        private void inkAddCliente_Click(object sender, EventArgs e)
        {
            closeChildForm();
            Form frm = new frmCadCliente();
            showFrm(frm);
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
    }
}
