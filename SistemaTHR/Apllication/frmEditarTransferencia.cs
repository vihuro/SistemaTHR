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
    public partial class frmEditarTransferencia : Form
    {
        public frmEditarTransferencia()
        {
            InitializeComponent();
            
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadStyleGridView1()
        {
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["numeroPA"].HeaderText = "Nº P.A";
            dataGridView1.Columns["codigo"].HeaderText = "Código";
            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["pesoBruto"].HeaderText = "Peso Bruto";
            dataGridView1.Columns["pesoLiquido"].HeaderText = "Peso Liquido";
            dataGridView1.Columns["Bobinas"].HeaderText = "Qt: Bobinas";
            dataGridView1.Columns["idTransferencia"].HeaderText = "ID/Transfenrecia";
            dataGridView1.Columns["usuarioTransferencia"].HeaderText = "Usuário/Transferencia";

            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["idTransferencia"].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            
            for(int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                MessageBox.Show("Vamos ver: " + dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[1].Value.ToString());

                if(dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[1].Value.ToString() == dataGridView2.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString())
                {
                    MessageBox.Show("Achei" + dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[1].Value.ToString());
                    break;
                }

                   
                
            }
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
    }
}
