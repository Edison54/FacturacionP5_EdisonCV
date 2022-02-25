using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.models
{
    public class Empresa
    {

        //Atributos simples

        public int IDEmpresa { get; set; }

        public String NombreEmpresa { get; set; }

        public String CedulaEmpresa { get; set; }

        public String EmailEmpresa { get; set; }
        public String DireccionEmpresa { get; set; }

        public String TelefonoEmpresa { get; set; }

        public String RutaImagen { get; set; }
     



        public DataTable Listar()
        {
            DataTable R = new DataTable();




            //datos necesarios para R
            return R;

        }

    }

    }
