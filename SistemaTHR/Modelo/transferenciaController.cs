﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Modelo
{
    internal class transferenciaController
    {
       public DateTime dataHoraTransf;
        String usuarioTransf;
        private void insertTransferencia()
        {
            DAO.transferenciaDao transferencDao= new DAO.transferenciaDao();
            transferencDao.insert(dataHoraTransf, usuarioTransf);
        }

        public void insert(DateTime dataHoraTransf, String usuarioTransf)
        {
            this.dataHoraTransf = dataHoraTransf;
            this.usuarioTransf = usuarioTransf;
            insertTransferencia();
        }

        public String numeroPa;
        public String codigo;
        public String descricao;
        public String pesoBruto;
        public String pesoLiquido;
        public String bobinas;
        public String idTransferencia;
        public String usuarioTransferencia;
        public DataTable dt = new DataTable();

        private void insertMovimentaoca()
        {
            DAO.transferenciaDao transferenciaDao = new DAO.transferenciaDao();
            transferenciaDao.insertMovimentacao(numeroPa, codigo, descricao, pesoBruto, pesoLiquido, bobinas, idTransferencia, usuarioTransferencia);

        }

        public void insertMov(String numeroPa, String codigo, String descricao, String pesoBruto, String pesoLiquido, String bobinas, String idTransferencia, String usuarioTransferencia)
        {
            this.numeroPa = numeroPa;
            this.codigo = codigo;
            this.descricao = descricao;
            this.pesoBruto = pesoBruto;
            this.pesoLiquido = pesoLiquido;
            this.bobinas = bobinas;
            this.idTransferencia = idTransferencia;
            this.usuarioTransferencia = usuarioTransferencia;
            insertMovimentaoca();

        }


        private void insertIntoFechamento()
        {
            DAO.transferenciaDao transferenciaDao = new DAO.transferenciaDao();
            transferenciaDao.InsertFechamento(codigo, descricao, pesoBruto, pesoLiquido, bobinas, idTransferencia);

        }

        public void InsertFechamento(String codigo, String descricao, String pesoBruto, String pesoLiquido, String bobinas, String idTransferencia)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.pesoBruto = pesoBruto;
            this.pesoLiquido = pesoLiquido;
            this.bobinas = bobinas;
            this.idTransferencia = idTransferencia;

            insertIntoFechamento();

        }

        public String id;

        private void selectIdTransf()
        {
            DAO.transferenciaDao transferenciaDao = new DAO.transferenciaDao();
            transferenciaDao.selectId();
            this.id = transferenciaDao.id;
            
        }

        public void selectId()
        {
            selectIdTransf();
        }

        private void selectFechamento()
        {
            DAO.transferenciaDao transferenciaDao = new DAO.transferenciaDao();
            transferenciaDao.selectFech(id);
            this.dt = transferenciaDao.dt;
        }

        public void selectFech(String id)
        {
            this.id = id;
            selectFechamento();
            
        }

        private void selectTransfenrecia()
        {
            DAO.transferenciaDao transferenciaDao = new DAO.transferenciaDao();
            transferenciaDao.selectTransf(id);
            this.dt = transferenciaDao.dt;
        }

        public void selectTransf(String id)
        {
            this.id = id;
            selectTransfenrecia();
        }

        private void selectFechamentos()
        {
            DAO.transferenciaDao transferenciaDao = new DAO.transferenciaDao();
            transferenciaDao.selecMovimenta(id);
            this.dt = transferenciaDao.dt;
        }

        public void selecMovimenta(String id)
        {
            this.id = id;
            selectFechamentos();
        }



        private void selectTransf()
        {
            DAO.transferenciaDao transferenciaDao = new DAO.transferenciaDao();
            transferenciaDao.selecTransf(id);
            this.dt = transferenciaDao.dt;

        }
        public void selectTransferencia()
        {
            selectTransf();
        }

        private void selectMovimentacao()
        {
            DAO.transferenciaDao transferenciaDao = new DAO.transferenciaDao();
            transferenciaDao.selectMovi(id);
            this.dt = transferenciaDao.dt;
        }

        public void selectMovi(String id)
        {
            this.id = id;
            selectMovimentacao();
        }
    }
}