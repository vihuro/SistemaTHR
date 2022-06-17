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
    public partial class frmPainelTrocaGas : Form
    {
        public frmPainelTrocaGas()
        {
            InitializeComponent();
            loadListView();
            //MessageBox.Show("AQui estou");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            String numero;

        public void loadListView()
        {
            Modelo.loadTrocaGasController loadTrocaGas = new Modelo.loadTrocaGasController();


            numero = loadTrocaGas.numeroEmp();
            MessageBox.Show(loadTrocaGas.empNumero.ToString());



        }
    }
}
