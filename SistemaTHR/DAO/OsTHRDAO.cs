using System;
using System.Collections.Generic;
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

        public String descricaoServico;
        public String tipoServico;
        public DateTime dataHoraGeraca;
        public String usuarioSolicitacao;
        public String statusOP;

        private void insertOS()
        {
            cmd.CommandText = "Insert into tab_OSTHR (DescricaoServico, TipoServico,DataHoraGeracao,UsuarioSolicitacao,StatusOP) " +
                            "Values(@DescricaoServico, @TipoServico, @DataHoraGeracao, @UsuarioSolicitacao, @StatusOP)";
            cmd.Parameters.AddWithValue("@DecricaoServico", descricaoServico);
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
        public DateTime dataHoraApontament;
        public DateTime dataAlteracao;
        public String usuarioApontamento;
        public String observacao;

        private void insertSTatusOP()
        {
            cmd.CommandText = "Insert into tab_StatusOSTHR (NumeroOSTHR, Andamento, DataHoraApontamento,DataHoraAlteracao,UsuarioApontamento,Observacao) " +
                 "Values(@NumeroOSTHR, @Andamento, @DataHoraApontamento, @DataHoraAlteracao, @UsuarioApontamento)";
            cmd.Parameters.AddWithValue("@numeroOSTHR",numeroOSTHR);
            cmd.Parameters.AddWithValue("@andamento", Andamento);
            cmd.Parameters.AddWithValue("@DataHoraApontamento", dataHoraApontament);
            cmd.Parameters.AddWithValue("@usuarioApontamento", usuarioApontamento);
            cmd.Parameters.AddWithValue("@observacao", observacao);


            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

            }
            catch
            {

            }

        }
    }
}
