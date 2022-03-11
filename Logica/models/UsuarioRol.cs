using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.models
{
    public class UsuarioRol
    {

        //Atributos simples


        public int IDUsuarioRol { get; set; }

        public String Rol { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            R = MiCnn.EjecutarSelect("SpUsuarioRolListar");


            //datos necesarios
            return R;

        }

    }
}
