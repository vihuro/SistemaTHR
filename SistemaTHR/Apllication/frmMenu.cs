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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void empilhadeira1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrocaGas frmTrocaGas = new frmTrocaGas();
            
            frmTrocaGas.lblNumeroEmp.Text = "1";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();
        }

        private void empilhadeira2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrocaGas frmTrocaGas = new frmTrocaGas();

            frmTrocaGas.lblNumeroEmp.Text = "2";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();
        }

        private void empilhadeira3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrocaGas frmTrocaGas = new frmTrocaGas();

            frmTrocaGas.lblNumeroEmp.Text = "3";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();

        }

        private void empilhadeira3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTrocaGas frmTrocaGas = new frmTrocaGas();

            frmTrocaGas.lblNumeroEmp.Text = "4";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();

        }

        private void empilhadeira3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTrocaGas frmTrocaGas = new frmTrocaGas();

            frmTrocaGas.lblNumeroEmp.Text = "5";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();

        }

        private void trocaGásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPainelTrocaGas frmPainelTrocaGas = new frmPainelTrocaGas();
            frmPainelTrocaGas.Show();
        }

        private void solicitarManutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolicitarManutencao frmSolicitarManutencao = new frmSolicitarManutencao();
            frmSolicitarManutencao.lblUsuario.Text = this.lblUsuario.Text;
            frmSolicitarManutencao.ShowDialog();
        }

        private void manutenççõesEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPainelManutencoesAberto frmPainelManutencoesAberto = new frmPainelManutencoesAberto();
            frmPainelManutencoesAberto.lblUsuario.Text = this.lblUsuario.Text;
     
            frmPainelManutencoesAberto.Show();
        }



        private void transfêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferencia frmTransferencia = new frmTransferencia();
            frmTransferencia.lblUsuario.Text = this.lblUsuario.Text;
            frmTransferencia.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeste frmTeste = new frmTeste();
            frmTeste.Show();
        }

        private void transferênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPainelTransferencias frmPainelTransferencias = new frmPainelTransferencias();
            frmPainelTransferencias.Show();
        }
    }
}
