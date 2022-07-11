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
        public String dataHoraGeraca;
        public String usuarioSolicitacao;
        public String statusOP;
        public DataTable dt = new DataTable();
        public String ASE;
        public String DataIdeal;
        public String Prioridade;
        public String usuarioPrioridade;
        public String dataHoraPrioridade;

        private void insertOS()
        {
            DAO.OsTHRDAO tHRDAO = new DAO.OsTHRDAO();
            tHRDAO.descricaoServico = this.descricaoServico;
            tHRDAO.tipoServico = this.tipoServico;
            tHRDAO.dataHoraGeraca = this.dataHoraGeraca;
            tHRDAO.usuarioSolicitacao = this.usuarioSolicitacao;
            tHRDAO.statusOP = this.statusOP;
            tHRDAO.insertOrdemServico(descricaoServico, tipoServico, dataHoraGeraca, usuarioSolicitacao,ASE,DataIdeal,statusOP);
        }

        public void insertOrdemServico(String descricaoServico, String tipoServico, String dataHoraGeraca, String usuarioSolicitacao,String ASE, String DataIdeal, String statusOP)
        {
            this.descricaoServico = descricaoServico;
            this.tipoServico = tipoServico;
            this.dataHoraGeraca = dataHoraGeraca;
            this.usuarioSolicitacao = usuarioSolicitacao;
            this.ASE = ASE;
            this.DataIdeal = DataIdeal;
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
            dao.insertStatusOS(numeroOSTHR, Andamento, dataHoraApontament,  usuarioApontamento, dataHoraAlteracao, usuarioAlteracao, observacao);
        }

        public void insertStatusOS(String numeroOSTHR, String Andamento, String dataHoraApontament,  String usuarioApontamento, String dataHoraAlteracao, String usuarioAlteracao, String observacao)
        {
            this.numeroOSTHR = numeroOSTHR;
            this.Andamento = Andamento;
            this.dataHoraApontament = dataHoraApontament;
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
            this.Prioridade = dao.Prioridade;
        }

        public void loadINFO(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            loadInfoOS();
        }

        private void verificarPrioridade()
        {
            DAO.OsTHRDAO dao = new DAO.OsTHRDAO();
            dao.VerificarPriori(numeroOSTHR);
            this.Prioridade = dao.Prioridade;

        }

        public void VerificarPriori(String NumeroOSTHR)
        {
            this.numeroOSTHR = NumeroOSTHR;
            verificarPrioridade();

        }

        private void UpdatePrioridade()
        {
            DAO.OsTHRDAO dao = new DAO.OsTHRDAO();
            dao.Prioridade = this.Prioridade;
            dao.usuarioPrioridade = this.usuarioPrioridade;
            dao.dataHoraPrioridade = this.dataHoraPrioridade;
            dao.UpdatePriori(numeroOSTHR);

        }

        public void UpdatePriori(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            UpdatePrioridade();
        }

        private void UpdateStatusOS()
        {
            DAO.OsTHRDAO dao = new DAO.OsTHRDAO();
            dao.status = statusOP;
            dao.UpdateStaOS(numeroOSTHR);
        }

        public void UpdateStaOS(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            UpdateStatusOS();
        }

        public String codigoPeca;
        public String descricaoPeca;
        public String QTD;
        public String unidade;
        public String nomeSolicitante;
        public String dataHoraSolicitacao;
        public String statusSolicitacao;

        private void insertRequisicaoPeca()
        {
            DAO.OsTHRDAO dao = new DAO.OsTHRDAO();
            dao.numeroOSTHR = numeroOSTHR;
            dao.codigoPeca = codigoPeca;
            dao.descricaoPeca = descricaoPeca;
            dao.QTD = QTD;
            dao.unidade = unidade;
            dao.nomeSolicitante = nomeSolicitante;
            dao.dataHoraSolicitacao = dataHoraSolicitacao;
            dao.statusSolicitacao = statusSolicitacao;
            dao.insertRequisicaoPecas();
        }

        public void insertRequisicaoPecas()
        {
            insertRequisicaoPeca();
        }

        private void selectRequisicaoPeca()
        {
            DAO.OsTHRDAO dao = new DAO.OsTHRDAO();
            dao.numeroOSTHR = numeroOSTHR;
            dao.selectPecas();
            this.dt = dao.dt;

        }

        public void selectPecas()
        {
            selectRequisicaoPeca();
        }
    }
}
