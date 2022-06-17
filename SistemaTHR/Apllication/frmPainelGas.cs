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

namespace SistemaTHR.Apllication
{
    public partial class frmPainelTrocaGas : Form
    {
        public frmPainelTrocaGas()
        {
            InitializeComponent();
            //listViewFinally();
            loadListView();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        public List<String> numeroEmp = new List<String>();
        public List<String> ultimaTroca = new List<String>();
        public List<String> trocaAtual = new List<String>();


        public void loadListView()
        {
            Modelo.loadTrocaGasController loadTrocaGasController = new Modelo.loadTrocaGasController();
            loadTrocaGasController.numeroEmp();
            numeroEmp = loadTrocaGasController.empNumero;
            ultimaTroca = loadTrocaGasController.ultimaTrocaList;
            trocaAtual = loadTrocaGasController.trocaAtualList;

            foreach (var list in numeroEmp)
            {
                ListViewItem lisItem = new ListViewItem(list);

                var ultimaTrocaList = new List<Array> { ultimaTroca.ToArray() };


                foreach(var listUltimaTroca in ultimaTroca)
                {
                    lisItem.SubItems.Add(listUltimaTroca);
                }
                foreach(var trocaAtualList in trocaAtual)
                {
                    lisItem.SubItems.Add(trocaAtualList);

                }


     

               listView1.Items.Add(lisItem);
            }


        }

        public void listViewFinally()
        {
            loadListView();

            foreach(var list in numeroEmp)
            {

                listView1.Items.Add(list);
            }

        }

        public List<String> loadTrocas()
        {
            /*cmd.CommandText = "Select * from tab_trocaGas order by dataHoraTroca asc";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //numero = dr["numeroEmp"].ToString();
                    numeroEmpilhadeira1 = dr["numeroEmp"].ToString();


                    numeroEmp.Add(numeroEmpilhadeira1);
                    MessageBox.Show(numeroEmpilhadeira1);
                    // Console.Write(dr["numeroEmp"].ToString());
                    // Console.Write(numeroEmp);*/
                    
                    /*Modelo.loadTrocaGasController loadTrovcaGasController = new Modelo.loadTrocaGasController();
                    loadTrocaGasController.numeroEmp();
                    ListViewItem list = new ListViewItem(loadTrocaGasController.empNumero.ToString());

                    listView1.Items.Add(list);*/

            return null;
        }



    }
    
}
