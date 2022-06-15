using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR
{
    internal class loginController
    {
        public bool tem;
        public string menssagem;

        public bool aceesar(String nome, String senha)
        {
           DAO.LoginDao loginDao = new DAO.LoginDao();
            tem = loginDao.verificar(nome,senha);

            if (!loginDao.menssagem.Equals(""))
            {
                this.menssagem = loginDao.menssagem;
            }
            return tem;
        }

    }
}
