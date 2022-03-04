using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.models
{  
public class Usuario
{
    //Atributos simples


    public int IDUsuario { get; set; }

    public String Nombre { get; set; }

    public String NombreUsuario { get; set; }

    public String Telefono { get; set; }
    public String CorreoDeRespaldo { get; set; }

    public String Contrasennia { get; set; }

    public String Cedula { get; set; }
    public bool Activo { get; set; }


        //Atributos compuesto

        UsuarioRol MiRol { get; set; }

    //constructor de la clase
    public Usuario()
    {

            //Aqui debemos instanciar MiTipo
            MiRol = new UsuarioRol();



    }

   
    public bool Agregar(String pNombre, String pNombreUsuario, String pTelefono , String pCorreoDeRespaldo , string pContrasennia,string pCedula)
    {
        bool R = false;
        Nombre = pNombre;
        NombreUsuario =pNombreUsuario;
        Telefono = pTelefono;
        CorreoDeRespaldo = pCorreoDeRespaldo;
        Contrasennia = pContrasennia;
        Cedula = pCedula;   

        return R;

    }

    public bool Editar(int pIDUsuario, String pNombre, String pNombreUsuario, String pTelefono, String pCorreoDeRespaldo, string pContrasennia, string pCedula)
    {


        bool R = false;


        return R;
    }

    public bool Eliminar(int pIDUsuario)
    {


        bool R = false;


        return R;
    }

    public bool ConsultarPorCedula(String pCedula)
    {


        bool R = false;


        return R;
    }
    public bool ConsultarPorEmail(String pCorreoDeRespaldo)
    {


        bool R = false;


        return R;
    }
    public bool ConsultarPorID(int pIDUsuario)
    {


        bool R = false;


        return R;
    }

    public DataTable ListarActivos(bool VerActivos = true)
    {
        DataTable R = new DataTable();

            // paso 2.1 y 2.2
            Conexion MiCnn = new Conexion();

            //paso 2.3 y 2.4
            R = MiCnn.EjecutarSelect("SpUsuariosListarActivos");


            //datos necesarios
            return R;

    }
    public DataTable ListarInactivos(bool VerActivos = false)
    {
        DataTable R = new DataTable();




        //datos necesarios
            return R;

    }

}
}
