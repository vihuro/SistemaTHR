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
    public partial class frmManutencao : Form
    {

        DataTable dt = new DataTable();
        public frmManutencao()
        {
            InitializeComponent();
            loadGridView1();
            // clearAll();

        }

        private void clearAll()
        {
            dataGridView2.ClearSelection();
            dataGridView2.DataSource = null;
            dataGridView1.ClearSelection();
        }

        private void loadGridView1()
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.selecOSAber();
            this.dt = controller.dt;

            dataGridView1.DataSource = dt;
            


            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
                if(i == dataGridView1.Rows.Count -1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i - 1].Cells[0];

                    
                    break;
                }
                
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        String numeroOS;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int i = dataGrid.SelectedRows.Count;
            
            if ( i > 0)
            {
                numeroOS = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();

                loadDataGridView2();
                
            }

        }

        private void loadStyleDataGridView2()
        {
            dataGridView2.Columns["NUMEROStatus"].HeaderText = "Nº Status";
            dataGridView2.Columns["NUMEROOSTHR"].HeaderText = "Numero/OS";
            dataGridView2.Columns["Observacao"].HeaderText = "Observação";

            dataGridView2.Columns["NUMEROStatus"].Visible = false;
            dataGridView2.Columns["NUMEROOSTHR"].Visible = false;
            dataGridView2.Columns["Observacao"].Visible = false;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Columns[4].DefaultCellStyle.SelectionForeColor = Color.BlueViolet;

        }

        private void loadDataGridView2()
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.SelecStatusOS(numeroOS);
            dataGridView2.DataSource = controller.dt;
            loadStyleDataGridView2();

            dataGridView2.ClearSelection();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DateTime datahora;
        
        private void btnApontar_Click(object sender, EventArgs e)
        {
            datahora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            if(dataGridView2.SelectedRows[0].Cells[3].Value.Equals("00/00/0000 00:00:00"))
            {
                dataGridView2.SelectedRows[0].Cells[3].Value = datahora;
                dataGridView2.SelectedRows[0].Cells[4].Value = lblUsuario.Text;
            }
            if(!dataGridView2.SelectedRows[0].Cells[3].Value.Equals("00/00/0000 00:00:00"))
            {
                dataGridView2.SelectedRows[0].Cells[5].Value = datahora;
                dataGridView2.SelectedRows[0].Cells[6].Value = lblUsuario.Text;
            }
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.dataHoraApontament = datahora.ToString();


        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {

                    if (dataGridView2.Rows[i].Cells[4].Value != "")
                    {
                        dataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    }

                }

        }

        private void frmManutencao_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            dataGridView2.DataSource = null;


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int i = dataGrid.SelectedRows.Count;

            if (dataGridView2.CurrentCell != null)
            {
                //MessageBox.Show(dataGridView2.CurrentCell.ToString());
                if (i > 0)
                {
                    if (dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].Value != null)
                    {
                       // MessageBox.Show(dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[1].Value.ToString());
                    }

                }
            }


        }
    }
}
