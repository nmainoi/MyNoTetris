using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNoTetris.Forms
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
           
        }
        public void CarregaUser(string usuario)
        {
            TXT_USUARIO.Text = usuario;
        }
        private void BT_JOGAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXT_USUARIO.Text))
            {
                MessageBox.Show("Por gentileza defina um usuário!","Usuário em branco!");
                return;
            }
            Game._user = TXT_USUARIO.Text;
            this.Close();
        }
    }
}
