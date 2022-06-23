using SistemaTHR.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SistemaTHR.Apllication
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
            loadGradeView();

            trocaGas();
        }

        public void loadGradeView()
        {

            DataGridView dataGridView = new DataGridView();

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.ColumnCount = 7;

            dataGridView.Columns[0].Name = "id";
            dataGridView.Columns[1].Name = "numeroEmp";
            dataGridView.Columns[2].Name = "ultimaTroca";
            dataGridView.Columns[3].Name = "TrocaAtual";
            dataGridView.Columns[4].Name = "HorasTrabalhadas";
            dataGridView.Columns[5].Name = "dataHoraTroca";
            dataGridView.Columns[6].Name = "UsuarioTroca";

            dataGridView.Columns["id"].HeaderText = "ID";
            dataGridView.Columns["numeroEmp"].HeaderText = "Numero Empilhadeira";
            dataGridView.Columns["ultimaTroca"].HeaderText = "Ultima Troca";
            dataGridView.Columns["TrocaAtual"].HeaderText = "Troca Atual";
            dataGridView.Columns["HorasTrabalhadas"].HeaderText = "Horas Trabalhadas";
            dataGridView.Columns["dataHoraTroca"].HeaderText = "Data/Hora Troca";
            dataGridView.Columns["UsuarioTroca"].HeaderText = "Usuário Troca";

        }


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds;

        private void trocaGas()
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            Connection con = new Connection();

            DataSet ds;
            //DataTable dt = new DataTable();


            cmd.CommandText = "Select * from tab_trocaGas order by dataHoraTroca asc";


                //con.conectar();
                cmd.Connection = con.conectar();


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.DataMember = dt.TableName;

                /*da = new OleDbDataAdapter(cmd);

                dt.Load(dr);*/


           
        }



        private void frmTeste_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
