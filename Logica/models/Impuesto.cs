using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.models
{
    public class Impuesto
    {
        public int IDImpuesto { get; set; }

        public String CodigoImpuesto{ get; set; }
        public String InpuestoNombre { get; set; }

        public decimal MontoImpuesto { get; set; }



        public DataTable Listar()
        {
            DataTable R = new DataTable();




            //datos necesarios para R
            return R;

        }




    }
}
