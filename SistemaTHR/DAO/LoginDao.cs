using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

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

    }
}
