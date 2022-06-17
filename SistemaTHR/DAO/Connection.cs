using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace SistemaTHR.DAO
{
    public class Connection
    {
        OleDbConnection conn = new OleDbConnection();
        String conexao;

        public Connection()
        {
            conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Vitor_2\\source\\repos\\SistemaTHR\\bd_SistemTHR.accdb;";

            conn.ConnectionString = conexao;
        }

        public OleDbConnection conectar()
        {
            conn.Open();
            return conn;
        }

        public void desconectar()
        {
            conn.Close();
        }
    }
}
