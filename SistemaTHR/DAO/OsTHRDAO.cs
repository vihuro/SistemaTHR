using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class OsTHRDAO
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        public DataTable dt = new DataTable();

        public String descricaoServico;
        public String tipoServico;
        public DateTime dataHoraGeraca;
        public String usuarioSolicitacao;
        public String statusOP;

        private void insertOS()
        {
            cmd.CommandText = "Insert into tab_OSTHR (DescricaoServico, TipoServico,DataHoraGeracao,UsuarioSolicitacao,StatusOP) " +
                            "Values (@DescricaoServico, @TipoServico, @DataHoraGeracao, @UsuarioSolicitacao, @StatusOP)";
            cmd.Parameters.AddWithValue("@DescricaoServico", descricaoServico);
            cmd.Parameters.AddWithValue("@TipoServico", tipoServico);
            cmd.Parameters.AddWithValue("@DataHoraGeracao", dataHoraGeraca);
            cmd.Parameters.AddWithValue("@UsuarioSolicitacao", usuarioSolicitacao);
            cmd.Parameters.AddWithValue("@StatusOP", statusOP);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();

                con.desconectar();

            }
            catch
            {

            }
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
            cmd.CommandText = "Select * from tab_OSTHR order by NOP asc";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    numeroOP = dr["NOP"].ToString();
                }

            }
            catch
            {

            }
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

        private void insertSTatusOP()
        {
            cmd.CommandText = "Insert into tab_StatusOSTHR (NumeroOSTHR, Andamento, DataHoraApontamento,UsuarioApontamento,DataHoraAlteracao,UsuarioAlteracao,Observacao) " +
                 "Values(@NumeroOSTHR, @Andamento, @DataHoraApontamento,@usuarioApontamento, @DataHoraAlteracao, @usuarioAlteracao,@observacao)";
            cmd.Parameters.AddWithValue("@NumeroOSTHR",numeroOSTHR);
            cmd.Parameters.AddWithValue("@Andamento", Andamento);
            cmd.Parameters.AddWithValue("@DataHoraApontamento", dataHoraApontament);
            cmd.Parameters.AddWithValue("@usuarioApontamento", usuarioApontamento);
            cmd.Parameters.AddWithValue("@DataHoraAlteracao", dataHoraAlteracao);
            cmd.Parameters.AddWithValue("@usuarioAlteracao", usuarioAlteracao);
            cmd.Parameters.AddWithValue("@observacao", observacao);



                cmd.Connection = con.conectar();
                cmd.ExecuteReader();

                con.desconectar();



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

        String status = "EM ABERTO";
        private void selectOSAberto()
        {
            cmd.CommandText = "Select * from tab_OSTHR where StatusOP = @status";
            cmd.Parameters.AddWithValue("@status", status);

            try
            {
                cmd.Connection = con.conectar();

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);

                con.desconectar();

            }
            catch
            {

            }

        }

        public void selecOSAber()
        {
            selectOSAberto();
        }

        private void selecStatus()
        {
            cmd.CommandText = "Select * from tab_StatusOSTHR where numeroOSTHR = @numeroOS";
            cmd.Parameters.AddWithValue("@numeroOS", numeroOSTHR);

            try
            {
                cmd.Connection = con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);

                con.desconectar();
            }
            catch
            {

            }
        }

        public void SelecStatusOS(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            selecStatus();
        }
        String numeroStatus;
        
        private void updateObservacao()
        {
            cmd.CommandText = "Update tab_StatusOSTHR set Observacao = @obeservacao" +
                "DataHoraApontamento = @dataHoraApontamento" +
                "usuarioApontamento = @usuarioApontamento" +
                "DataHoraAlteracao = @dataHoraAlteracao" +
                "@usuarioAlteracao = @usuarioAlteracao" +
                " where numeroStatus = @numeroStatus";

            cmd.Parameters.AddWithValue("@dataHoraApontamento", dataHoraApontament);
            cmd.Parameters.AddWithValue("@usuarioApontamento", usuarioApontamento);
            cmd.Parameters.AddWithValue("@dataHoraAlteracao", dataHoraAlteracao);
            cmd.Parameters.AddWithValue("@usuarioAlteracao", usuarioAlteracao);

            cmd.Parameters.AddWithValue("@numeroStatus", numeroStatus);
            cmd.Parameters.AddWithValue("@observacao", observacao);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();

                con.desconectar();
                

            }
            catch
            {

            }

        }

        public void updateOBS(String numeroStatus)
        {
            this.numeroStatus = numeroStatus;
            updateObservacao();
        }
    }
}
