using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class loadPaController
    {
        public String descricao;
        public String codigo;
        public double pesoBruto;
        public double pesoLiquido;
        public double qtBobinas;

        public void selectPA(String numeroPA)
        {
            DAO.loadPADAO loadPADAO = new DAO.loadPADAO();
            loadPADAO.selectPA(numeroPA);

            this.descricao = loadPADAO.descricao;
            this.codigo = loadPADAO.codigo;
            this.pesoBruto = loadPADAO.pesoBruto;
            this.pesoLiquido = loadPADAO.pesoLiquido;
            this.qtBobinas = loadPADAO.qtBobinas;
        }
    }
}
