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

        public String Empilhadeiras;
        public String EmpNivel;
        public String Recebimento;
        public String RecebNivel;
        public String Expedicao;
        public String ExpNivel;
        public String Adm;
        public String AdmNivel;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginController loginController = new loginController();
            loginController.aceesar(txtNome.Text, txtSenha.Text);

            if (loginController.tem)
            {

                frmMenu menu = new frmMenu();


                menu.lblUsuario.Text = txtNome.Text;

                loginController.verificarNivel(txtNome.Text);
                this.Empilhadeiras = loginController.Empilhadeiras;
                this.EmpNivel = loginController.EmpNivel;
                this.Recebimento = loginController.Recebimento;
                this.RecebNivel = loginController.RecebNivel;
                this.Expedicao = loginController.Expedicao;
                this.ExpNivel = loginController.ExpNivel;
                this.Adm = loginController.Adm;
                this.AdmNivel = loginController.AdmNivel;

                menu.empilhadeirasToolStripMenuItem.Enabled = false;
                menu.recebimentoToolStripMenuItem.Enabled = false;
                menu.expediçãoToolStripMenuItem.Enabled = false;
                menu.gerenciarLoginsToolStripMenuItem.Enabled = false;

                if(this.Empilhadeiras == "Sim")
                {
                    menu.empilhadeirasToolStripMenuItem.Enabled = true;
                }
                if (this.Recebimento == "Sim")
                {
                    menu.recebimentoToolStripMenuItem.Enabled = true;
                }
                if (this.Expedicao == "Sim")
                {
                    menu.expediçãoToolStripMenuItem.Enabled = true;
                }
                if (this.Adm == "Sim")
                {
                    menu.gerenciarLoginsToolStripMenuItem.Enabled = true;
                }

                this.txtNome.Text = string.Empty;
                this.txtSenha.Text = string.Empty;

                menu.Show();

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
