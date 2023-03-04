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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           /* if(txtLogin.Text.Length == 0 || txtSenha.Text.Length == 0) 
            {
                MessageBox.Show("Preencha Login / Senha para continuar!", "Advertência");
            }*/
           this.Hide();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
