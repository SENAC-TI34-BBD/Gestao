using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void dadosContato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            lockForm();
        }

        public void lockForm()
        {
                grpVazio.Enabled = false;
                grpVazio2.Enabled = false;
                grpVazio3.Enabled = false;
                grpVazioCob.Enabled = false;
                grpDetalhesOutros.Enabled = false;

        }
        public void unlockForm()
        {
            grpVazio.Enabled = true;
            grpVazio2.Enabled = true;
            grpVazio3.Enabled = true;
            grpVazioCob.Enabled = true;
            grpDetalhesOutros.Enabled = true;
        }
    }
}
