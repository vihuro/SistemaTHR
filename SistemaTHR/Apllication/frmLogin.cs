using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using SistemaTHR.Apllication;

namespace SistemaTHR
{

    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }



        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginController loginController = new loginController();
            loginController.aceesar(txtNome.Text, txtSenha.Text);

            if (loginController.tem)
            {


                frmMenu menu = new frmMenu();
                menu.Show();

                menu.lblUsuario.Text = txtNome.Text;



                this.txtNome.Text = string.Empty;
                this.txtSenha.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
  
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Close();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            if(txtSenha.PasswordChar.ToString() == "•")
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '•';
            }
        }
    }
}
