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
    public partial class frmSolicitacaoPeca : Form
    {
        String usuario;
        String numeroOS;
        public frmSolicitacaoPeca(String usuario, String numeroOS)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.numeroOS = numeroOS;
            loadDataGridView1();
        }

        private void loadDataGridView1()
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.numeroOSTHR = numeroOS;
            controller.selectPecas();
            dataGridView1.DataSource = controller.dt;
        }
        private void frmSolicitacaoPeca_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.numeroOSTHR = numeroOS;
            controller.codigoPeca = txtCodigo.Text;
            controller.descricaoPeca = txtDescricao.Text;
            controller.QTD = txtQuantidade.Text;
            controller.unidade = txtUnidade.Text;
            controller.nomeSolicitante = usuario;
            controller.dataHoraSolicitacao = "Testando";
            controller.statusSolicitacao = "AGUARDANDO/AUT. PEÇAS";

            controller.insertRequisicaoPecas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
