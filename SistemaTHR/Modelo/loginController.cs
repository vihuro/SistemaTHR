using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR
{
    internal class loginController
    {
        public bool tem;
        public string menssagem;
        public String usuario;
        public String Empilhadeiras = "Não";
        public String EmpNivel = "0";
        public String Recebimento = "Não";
        public String RecebNivel = "0";
        public String Expedicao = "Não";
        public String ExpNivel = "0";
        public String Adm = "Não";
        public String AdmNivel = "0";
        public String nomeUsuario;

        public bool aceesar(String nome, String senha)
        {
            DAO.LoginDao loginDao = new DAO.LoginDao();
            tem = loginDao.verificar(nome, senha);

            if (!loginDao.menssagem.Equals(""))
            {
                this.menssagem = loginDao.menssagem;
            }
            return tem;
        }

        private void verificarNivel()
        {
            DAO.LoginDao loginDao = new DAO.LoginDao();
            loginDao.verificarNivel(usuario);
            this.usuario = loginDao.usuario;
            this.Empilhadeiras = loginDao.Empilhadeiras;
            this.EmpNivel = loginDao.EmpNivel;
            this.Recebimento = loginDao.Recebimento;
            this.RecebNivel = loginDao.RecebNivel;
            this.Expedicao = loginDao.Expedicao;
            this.ExpNivel = loginDao.ExpNivel;
            this.Adm = loginDao.Adm;
            this.AdmNivel = loginDao.AdmNivel;

        }
        public void verificarNivel(String usuario)
        {
            this.usuario = usuario;
            verificarNivel();
        }

        public DataTable dt = new DataTable();

        private void loadUsuario()
        {
            DAO.LoginDao login = new DAO.LoginDao();
            login.loadUser();
            this.dt = login.dt;

        }
        public void loadUser()
        {
            loadUsuario();

        }

        private void loadInformacoes()
        {
            DAO.LoginDao loginDao = new DAO.LoginDao();
            loginDao.loadInfo(usuario);

            this.Empilhadeiras = loginDao.Empilhadeiras;
            this.EmpNivel = loginDao.EmpNivel;
            this.Recebimento = loginDao.Recebimento;
            this.RecebNivel = loginDao.RecebNivel;
            this.Expedicao = loginDao.Expedicao;
            this.ExpNivel = loginDao.ExpNivel;
            this.Adm = loginDao.Adm;
            this.AdmNivel = loginDao.AdmNivel;

            


        }

        public void loadInfo(String usuario)
        {
            this.usuario = usuario;
            loadInformacoes();

        }

        private void SelectNome()
        {
            DAO.LoginDao dao = new DAO.LoginDao();
            dao.SelecNomeUsuario(usuario);
            this.nomeUsuario = dao.nomeUsuario;

        }

        public void SelecNomeUsuario(String usuario)
        {
            this.usuario = usuario;
            SelectNome();
        }
    }
}
