using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class loadTrocaGasController
    {
        public String empNumero;

        public String numeroEmp()
        {
            DAO.loadTrocasDao loadTrocaGas = new DAO.loadTrocasDao();
            loadTrocaGas.loadTrocas();
            //this.empNumero = loadTrocaGas.numeroEmp;
            if (!loadTrocaGas.Equals(""))
            {
                this.empNumero = loadTrocaGas.numeroEmp.ToString(); 
            }
            
            return empNumero;
        }
    }
}
