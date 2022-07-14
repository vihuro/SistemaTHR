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
        public String numeroRequisicao;
        public String nomeAutorizador;
        public String dataHoraAutorizacao;
        DAO.OsTHRDAO dao = new DAO.OsTHRDAO();

        private void insertOS()
        {

            dao.descricaoServico = this.descricaoServico;
            dao.tipoServico = this.tipoServico;
            dao.dataHoraGeraca = this.dataHoraGeraca;
            dao.usuarioSolicitacao = this.usuarioSolicitacao;
            dao.statusOP = this.statusOP;
            dao.insertOrdemServico(descricaoServico, tipoServico, dataHoraGeraca, usuarioSolicitacao,ASE,DataIdeal,statusOP);
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

            dao.selectOrdemServico();
            this.numeroOP = dao.numeroOP;
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

            dao.selecOSAber();
            this.dt = dao.dt;
        }

        public void selecOSAber()
        {
            SelectOSAberto();
        }

        private void selecStatus()
        {

            dao.SelecStatusOS(numeroOSTHR);
            this.dt = dao.dt;
        }

        public void SelecStatusOS(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            selecStatus();
        }

        private void updateStatusOS()
        {

            dao.dataHoraApontament = this.dataHoraApontament;
            dao.usuarioApontamento = this.usuarioApontamento;
            dao.dataHoraAlteracao = this.dataHoraAlteracao;
            dao.usuarioAlteracao = this.usuarioAlteracao;
            dao.observacao = this.observacao;
            dao.updateStatus(numeroStatus);
        }
        public void updateStatus(String numeroStatus)
        {
            this.numeroStatus = numeroStatus;
            updateStatusOS();
        }

        private void selectObservacao()
        {

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

            dao.numeroOSTHR = numeroOSTHR;
            dao.selectPecas();
            this.dt = dao.dt;

        }

        public void selectPecas()
        {
            selectRequisicaoPeca();
        }

        private void SelectInfoRequisicao()
        {

            dao.numeroRequisicao = numeroRequisicao;
            dao.selectInfoRequi();
            codigoPeca = dao.codigoPeca;
            descricaoPeca = dao.descricaoPeca;
            QTD = dao.QTD;
            unidade = dao.unidade;
        }

        public void selectInfoRequi()
        {
            SelectInfoRequisicao();

        }
        private void autRequisicao()
        {

            dao.numeroRequisicao = numeroRequisicao;
            dao.nomeAutorizador = nomeAutorizador;
            dao.dataHoraAutorizacao = dataHoraAutorizacao;
            dao.autorizarRequisicao();
        }

        public void autorizarRequisicao()
        {
            autRequisicao();
        }

        private void selectImpOS()
        {
            dao.numeroOSTHR = numeroOSTHR;
            dao.selectImpOrdemServico();
            dt = dao.dt;
        }

        public void selectImpOrdemServico()
        {
            selectImpOS();
        }

    }
}
