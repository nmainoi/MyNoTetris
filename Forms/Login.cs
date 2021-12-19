using System;
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
                MessageBox.Show("Por gentileza defina um usuário!", "Usuário em branco!");
                return;
            }
            Classes.SQL._user = TXT_USUARIO.Text;
            CreateUser();
            this.Close();
        }

        private void CreateUser()
        {
            int numberOftrys = 0;
tryagain:
            if (numberOftrys > 1)
            {
                MessageBox.Show("Algo deu errado com o banco de dados, contate um administrador!");
                this.Close();
                return;
            }
            string mysql = "Select ID FROM [BDTetris].[dbo].[USER](nolock) WHERE NAME= '" + TXT_USUARIO.Text + "'";
            string UserHasName = Classes.SQL.ReadSQL(mysql);

            if (string.IsNullOrEmpty(UserHasName))/* so insere novo usuario se nao le direto */
            {
                numberOftrys++;
                mysql = "INSERT INTO [BDTetris].[dbo].[USER] (NAME) VALUES ( '" + TXT_USUARIO.Text + "')";
                Classes.SQL.InsertSQL(mysql);
                goto tryagain;
            }
            Classes.SQL._user = TXT_USUARIO.Text;
            Classes.SQL._id = int.Parse(UserHasName);
        }
    }
}