using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication
{
    public partial class frmGerenciarLogin : Form
    {
        public frmGerenciarLogin()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGerenciarLogin_Load(object sender, EventArgs e)
        {

        }

        String nomeUsuario;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.SelectedRows.Count;
            if(i > 0)
            {
                nomeUsuario = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();

                loginController login = new loginController();
                login.loadInfo(nomeUsuario);

                txtUsuario.Text = nomeUsuario;

                if(login.Expedicao == "Sim")
                {
                    rbExpSim.Checked = true;
                }

                else
                {
                    rbExpNao.Checked = true;
                    cboExp.Enabled = false;
                }

                if (login.Empilhadeiras == "Sim")
                {
                    rbEmpSim.Checked = true;
                }

                else
                {
                    rbEmpNao.Checked = true;
                    cboExp.Enabled = false;
                }

                if (login.Recebimento == "Sim")
                {
                    rbEmpRecebSim.Checked = true;
                }
                else
                {
                    rbRecebeNao.Checked = true;
                    cboReceb.Enabled = false;
                }

                if (login.Adm == "Sim")
                {
                    rbAdmSim.Checked = true;
                }
                else
                {
                    rbAdmNao.Checked = true;
                    cboAdm.Enabled = false;
                }

                cboAdm.Text = login.AdmNivel;
                cboEmp.Text = login.EmpNivel;
                cboExp.Text = login.ExpNivel;
                cboReceb.Text = login.RecebNivel;

                //MessageBox.Show(nomeUsuario);

            }

        }

        private void cboEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbEmpSim.Checked = true)
            {
                cboExp.Enabled = false;
            }
            else
            {
                cboExp.Enabled=true;
            }
        }

        private void rbEmpSim_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbEmpSim_Click(object sender, EventArgs e)
        {
            if (rbEmpSim.Checked == true)
            {
                cboEmp.Enabled = true;
            }
            else
            {
                cboEmp.Enabled = false;
            }

        }

        private void rbEmpNao_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rbEmpNao_Click(object sender, EventArgs e)
        {
            if (rbEmpNao.Checked == true)
            {
                cboEmp.Enabled = false;
            }
            else
            {
                cboEmp.Enabled = true;
            }

        }
    }
}
