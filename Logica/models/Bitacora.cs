using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.models
{
    public class Bitacora
    {
        public int IDBitacora { get; set; }

        public DateTime Fecha { get; set; }

        public string Accion { get; set; }

        Usuario MiUsuario { get; set; }

        public Bitacora()
        {
            //Aqui debemos instanciar MiUsuario

            MiUsuario = new Usuario();
           
        }

        public bool Agregar( string Mensaje)
        {
            bool R = false;

         
            return R;

        }

        public DataTable Listar(DateTime FechaInicio, DateTime FechaFinal)
        {
            DataTable R = new DataTable();


            return R;
        }

    }
}
