using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace Gestao
{
    public class clsConexao
    {
        private static string conexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=gestaoprod;user id=sa;password=sa";
        public static string stringConexao
        {
            get
            {
                return conexao;
            }
        }
    }
}
