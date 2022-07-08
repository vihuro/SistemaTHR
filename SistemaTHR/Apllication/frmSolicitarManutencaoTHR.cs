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
    public partial class frmSolicitarManutencaoTHR : Form
    {
        public frmSolicitarManutencaoTHR()
        {
            InitializeComponent();
        }
        public String numeroOP;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(cboAondeSera.Text != string.Empty && cboTipoServico.Text != string.Empty && txtDescricao.Text != string.Empty)
            {
                DateTime dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

                Modelo.OSTHRController oSTHRController = new Modelo.OSTHRController();
                oSTHRController.insertOrdemServico(txtDescricao.Text, cboTipoServico.Text, dataHora, lblUsuario.Text, "EM ABERTO");

                oSTHRController.selectOrdemServico();
                this.numeroOP = oSTHRController.numeroOP;

                String geracao = "Geração" ;


                oSTHRController.insertStatusOS(numeroOP,geracao, Convert.ToString(dataHora), "00/00/0000 00:00:00", lblUsuario.Text, "00/00/0000 00:00:00", "", "");

                String IniMan = "Início de manutenção";

                oSTHRController.insertStatusOS(numeroOP, IniMan, "00/00/0000 00:00:00", "00/00/0000 00:00:00", "", "00/00/0000 00:00:00", "", "");

                String RequisicaoPeca = "Requisição de peça";

                oSTHRController.insertStatusOS(numeroOP, RequisicaoPeca, "00/00/0000 00:00:00", "00/00/0000 00:00:00", "", "00/00/0000 00:00:00", "", "");

                String OrdemNaoProcede = "inconsistência da OS";

                oSTHRController.insertStatusOS(numeroOP, OrdemNaoProcede, "00/00/0000 00:00:00", "00/00/0000 00:00:00","", "00/00/0000 00:00:00", "", "");

                String FinMan = "Fim de manutenção";

                oSTHRController.insertStatusOS(numeroOP, FinMan, "00/00/0000 00:00:00", "00/00/0000 00:00:00", "", "00/00/0000 00:00:00", "", "");

                String OSNaoProcede = "Manutenção N/C";

                String OSFin = "OS Finalizada";


                MessageBox.Show("Serviço solicitado com sucesso!", "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
            else
            {
                MessageBox.Show("Campos obrigatório(s) vazio(s)", "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSolicitarManutencaoTHR_Load(object sender, EventArgs e)
        {

        }
    }
}
