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
    public partial class frmPainelTransferencias : Form
    {
        public frmPainelTransferencias()
        {
            InitializeComponent();
            loadGridView1();
            
        }

        DataTable dt = new DataTable();

        private void loadStyleGridView1()
        {
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "dataHoraTransf";
            dataGridView1.Columns[2].Name = "usuarioTransf";


            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["dataHoraTransf"].HeaderText = "Data/Hora Transferencia";
            dataGridView1.Columns["usuarioTransf"].HeaderText = "Usuário/Transferencia";


            //dataGridView1.Columns["id"].Visible = false;
        }
        private void loadGridView1()
        {
            Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
            transferenciaController.selectTransferencia();
            this.dt = transferenciaController.dt;

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = dt.TableName;
            loadStyleGridView1();

        }

        private void frmPainelTransferencias_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value != null && e.Value.Equals("Vitor"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.BlueViolet;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Black;
                
            }
        }
        String idSelecionado;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int i = dataGridView.SelectedRows.Count;

            if(i > 0)
            {
                idSelecionado = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                loadDataGridView2();
                loadDataGridView3();
            }
            
        }

        private void loadDataGridView2() 
        {
            Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
            transferenciaController.selectMovi(idSelecionado);
            this.dt = transferenciaController.dt;

            dataGridView2.DataSource = dt;
        }

        private void loadDataGridView3()
        {
            Modelo.transferenciaController transferencia = new Modelo.transferenciaController();
            transferencia.selectFech(idSelecionado);
            this.dt = transferencia.dt;

            dataGridView3.DataSource = dt;
        }

        
    }
}
