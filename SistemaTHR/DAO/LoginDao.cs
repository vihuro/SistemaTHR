using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace SistemaTHR.DAO
{
    internal class LoginDao
    {
        public bool tem = false;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        public String menssagem = "";

        public bool verificar(String usuario, String senha)
        {
            cmd.CommandText = "Select * from tbUsuario where Usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }

            }
            catch (Exception)
            {
                this.menssagem = "Erro com banco de dados";
            }
            return tem;
        }

        public String usuario;
        public String Empilhadeiras = "Não";
        public String EmpNivel = "0";
        public String Recebimento = "Não";
        public String RecebNivel = "0";
        public String Expedicao = "Não";
        public String ExpNivel = "0";
        public String Adm = "Não";
        public String AdmNivel = "0";

        private void verificarNivel()
        {
            cmd.CommandText = "Select * from tabModulos where Usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                        usuario = dr["usuario"].ToString();

                        Empilhadeiras = dr["Empilhadeiras"].ToString();
                        EmpNivel = dr["EmpNivel"].ToString();


                        Recebimento = dr["Recebimento"].ToString();
                        RecebNivel = dr["recebNivel"].ToString();


                        Expedicao = dr["Expedicao"].ToString();
                        ExpNivel = dr["ExpNivel"].ToString();

                        
                        Adm = dr["ADM"].ToString();
                        AdmNivel = dr["ADMNivel"].ToString();


                }

            }
            catch
            {

            }

        }
        public DataTable dt = new DataTable();
        private void loadUsuario()
        {
            cmd.CommandText = "Select * from tabModulos";
            

            try
            {
                cmd.Connection=con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);

            }
            catch
            {

            }
        }
        

        private void loadInformacoes()
        {
            cmd.CommandText = "Select * from tabModulos where Usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usuario = dr["usuario"].ToString();

                    Empilhadeiras = dr["Empilhadeiras"].ToString();
                    EmpNivel = dr["EmpNivel"].ToString();


                    Recebimento = dr["Recebimento"].ToString();
                    RecebNivel = dr["recebNivel"].ToString();


                    Expedicao = dr["Expedicao"].ToString();
                    ExpNivel = dr["ExpNivel"].ToString();


                    Adm = dr["ADM"].ToString();
                    AdmNivel = dr["ADMNivel"].ToString();



                }
            }
            catch
            {

            }
        }

        public void loadInfo(String usuario)
        {
            this.usuario = usuario;
            loadInformacoes();
        }

        public void loadUser()
        {
            
            loadUsuario();
        }

        public void verificarNivel(String usuario)
        {
            this.usuario = usuario;
            verificarNivel();

        }

    }
}
