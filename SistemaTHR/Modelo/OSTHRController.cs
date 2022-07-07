using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class OSTHRController
    {
        public String descricaoServico;
        public String tipoServico;
        public DateTime dataHoraGeraca;
        public String usuarioSolicitacao;
        public String statusOP;
        public DataTable dt = new DataTable();

        private void insertOS()
        {
            DAO.OsTHRDAO tHRDAO = new DAO.OsTHRDAO();
            tHRDAO.descricaoServico = this.descricaoServico;
            tHRDAO.tipoServico = this.tipoServico;
            tHRDAO.dataHoraGeraca = this.dataHoraGeraca;
            tHRDAO.usuarioSolicitacao = this.usuarioSolicitacao;
            tHRDAO.statusOP = this.statusOP;
            tHRDAO.insertOrdemServico(descricaoServico, tipoServico, dataHoraGeraca, usuarioSolicitacao, statusOP);
        }

        public void insertOrdemServico(String descricaoServico, String tipoServico, DateTime dataHoraGeraca, String usuarioSolicitacao, String statusOP)
        {
            this.descricaoServico = descricaoServico;
            this.tipoServico = tipoServico;
            this.dataHoraGeraca = dataHoraGeraca;
            this.usuarioSolicitacao = usuarioSolicitacao;
            this.statusOP = statusOP;
            insertOS();
        }

        public String numeroOP;
        private void selectOS()
        {
            DAO.OsTHRDAO osTHRDAO = new DAO.OsTHRDAO();
            osTHRDAO.selectOrdemServico();
            this.numeroOP = osTHRDAO.numeroOP;
        }

        public void selectOrdemServico()
        {
            selectOS();
        }
        public String numeroOSTHR;
        public String Andamento;
        public String dataHoraApontament;
        public String dataAlteracao;
        public String usuarioApontamento;
        public String dataHoraAlteracao;
        public String usuarioAlteracao;
        public String observacao;
        String numeroStatus;
        private void insertSTatusOP()
        {
            DAO.OsTHRDAO dao = new DAO.OsTHRDAO();
            dao.insertStatusOS(numeroOSTHR, Andamento, dataHoraApontament, dataAlteracao, usuarioApontamento, dataHoraAlteracao, usuarioAlteracao, observacao);
        }

        public void insertStatusOS(String numeroOSTHR, String Andamento, String dataHoraApontament, String dataAlteracao, String usuarioApontamento, String dataHoraAlteracao, String usuarioAlteracao, String observacao)
        {
            this.numeroOSTHR = numeroOSTHR;
            this.Andamento = Andamento;
            this.dataHoraApontament = dataHoraApontament;
            this.dataAlteracao = dataAlteracao;
            this.usuarioApontamento = usuarioApontamento;
            this.dataHoraAlteracao = dataHoraAlteracao;
            this.usuarioAlteracao = usuarioAlteracao;
            this.observacao = observacao;
            insertSTatusOP();
        }

        private void SelectOSAberto()
        {
            DAO.OsTHRDAO osTHRDAO = new DAO.OsTHRDAO();
            osTHRDAO.selecOSAber();
            this.dt = osTHRDAO.dt;
        }

        public void selecOSAber()
        {
            SelectOSAberto();
        }

        private void selecStatus()
        {
            DAO.OsTHRDAO tHRDAO = new DAO.OsTHRDAO();
            tHRDAO.SelecStatusOS(numeroOSTHR);
            this.dt = tHRDAO.dt;
        }

        public void SelecStatusOS(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            selecStatus();
        }

        private void updateStatusOS()
        {
            DAO.OsTHRDAO osTHRDAO = new DAO.OsTHRDAO();
            osTHRDAO.dataHoraApontament = this.dataHoraApontament;
            osTHRDAO.usuarioApontamento = this.usuarioApontamento;
            osTHRDAO.dataHoraAlteracao = this.dataHoraAlteracao;
            osTHRDAO.usuarioAlteracao = this.usuarioAlteracao;
            osTHRDAO.observacao = this.observacao;
            osTHRDAO.updateStatus(numeroStatus);
        }
        public void updateStatus(String numeroStatus)
        {
            this.numeroStatus = numeroStatus;
            updateStatusOS();
        }

        private void selectObservacao()
        {
            DAO.OsTHRDAO dao = new DAO.OsTHRDAO();
            dao.selectOBS(numeroStatus);
            this.observacao = dao.observacao;
        }

        public void selectOBS(String numeroStatus)
        {
            this.numeroStatus = numeroStatus;
            selectObservacao();
        }

        private void loadInfoOS()
        {
            DAO.OsTHRDAO dao = new DAO.OsTHRDAO();
            dao.loadINFO(numeroOSTHR);
            this.descricaoServico = dao.descricaoServico;
        }

        public void loadINFO(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            loadInfoOS();
        }
    }
}
