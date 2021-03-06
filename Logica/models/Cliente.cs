using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.models
{
    public class Cliente
    {
        //Atributos simples


        public int IDCliente { get; set; }

        public String Nombre { get; set; }

        public String Cedula { get; set; }

        public String Telefono { get; set; }

        public String Email { get; set; }

        public bool Activo { get; set; }


        //Atributos compuesto

        public ClienteTipo MiTipo { get; set; }

        //constructor de la clase
        public Cliente()
        {

            //Aqui debemos instanciar MiTipo
            MiTipo = new ClienteTipo();
        }

        // ejercicio clase
        public bool Agregar(String pNombre,String pCedula, String pTelefono= "", String pEmail="") 
        { 
            bool R = false;
            Nombre = pNombre;
            Cedula = pCedula;
            Telefono = pTelefono;
            Email = pEmail;

            return R;
            //prueba
        }

        public bool Editar(int pIDCliente, String pNombre, String pCedula, String pTelefono = "", String pEmail = "")
        {


            bool R = false;
         

            return R;
        }

        public bool Eliminar(int pIDCliente)
        {


            bool R = false;


            return R;
        }

        public bool ConsultarPorCedula(String pCedula)
        {


            bool R = false;


            return R;
        }
        public bool ConsultarPorID(int pIDCliente)
        {


            bool R = false;


            return R;
        }

        public DataTable Listar(bool verActivos = true , string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MyCnn= new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MyCnn.EjecutarSelect("SpClientesListar");





            //datos necesarios
            return R;

        }


    }
}
