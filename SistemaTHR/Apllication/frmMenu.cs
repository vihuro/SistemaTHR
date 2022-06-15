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
            frmTrocaGas trocaGas = new frmTrocaGas();
            trocaGas.lblNumeroEmp.Text = "1";
            trocaGas.Show();
        }

        private void empilhadeira1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTrocaGas trocaGas = new frmTrocaGas();
            trocaGas.lblNumeroEmp.Text = "2";
            trocaGas.Show();
        }

        private void empilhadeira1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTrocaGas trocaGas = new frmTrocaGas();
            trocaGas.lblNumeroEmp.Text = "3";
            trocaGas.Show();
        }

        private void empilhadeira1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmTrocaGas trocaGas = new frmTrocaGas();
            trocaGas.lblNumeroEmp.Text = "4";
            trocaGas.Show();
        }

        private void empilhadeira5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrocaGas trocaGas = new frmTrocaGas();
            trocaGas.lblNumeroEmp.Text = "5";
            trocaGas.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void empilhadeira1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmTrocaGas trocaGas = new frmTrocaGas();
            trocaGas.lblNumeroEmp.Text = "1";
            trocaGas.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void empilhadeira1ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmTrocaGas trocaGas = new frmTrocaGas();
            trocaGas.lblNumeroEmp.Text = "2";
            trocaGas.Show();
        }

        private void empilhadeira1ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmTrocaGas trocaGas = new frmTrocaGas();
            trocaGas.lblNumeroEmp.Text = "3";
            trocaGas.Show();

        }

        private void empilhadeira1ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmTrocaGas trocaGas = new frmTrocaGas();
            trocaGas.lblNumeroEmp.Text = "4";
            trocaGas.Show();

        }

        private void empilhadeira1ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmTrocaGas trocaGas = new frmTrocaGas();
            trocaGas.lblNumeroEmp.Text = "4";
            trocaGas.Show();

        }

        private void trocasDeGásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPainelTrocaGas painelTrocas = new frmPainelTrocaGas();

            painelTrocas.Show();


        }

        private void empilhadeirasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
