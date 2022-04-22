using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.models
{
    public class FacturaTipo
    {
        //1 Atributos
        private int iDFacturaTipo;

        public int IDFacturaTipo { 
        
        get { return iDFacturaTipo; }
        set { iDFacturaTipo = value; }
        
        
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();




            Conexion MyCnn = new Conexion();

            R = MyCnn.EjecutarSelect("SpFacturasTipoListar");
            return R;

        }
        


    }
}
