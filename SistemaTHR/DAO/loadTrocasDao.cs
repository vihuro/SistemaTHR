using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class loadTrocasDao
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();

        public String numeroEmp;


        public String loadTrocas()
        {
            cmd.CommandText = "Select * from tab_trocaGas order by dataHoraTroca asc";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                   numeroEmp = dr["numeroEmp"].ToString();

                }

            }
            catch
            {
                dr = null;
            }

            return numeroEmp;
        }
    }
}
