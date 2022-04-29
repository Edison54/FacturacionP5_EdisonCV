using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.models
{
  public  class Producto
    {
        public int IDProducto { get; set; }

        public String CodigoBarras { get; set; }
        public String DescripcionProducto { get; set; }
       

        public decimal CantidadEnStock { get; set; }

        public decimal PrecioUnitario { get; set; }


        //Atributos Compuestos



       public UnidadMedida MiunidadMedida { get; set; }
        public ProductoCategoria MiCategoria { get; set; }
        public Impuesto MiImpuesto { get; set; }

        //constructor de la clases
        public Producto()
        {

            //Aqui debemos instanciar MiTipo
            MiunidadMedida = new UnidadMedida();
            MiCategoria = new ProductoCategoria();
            MiImpuesto = new Impuesto();

        }

        //funciones y metodos
        public bool Agregar(String pCodigoBarras, String pDescripcionProducto, decimal pCantidadEnStock, decimal pPrecioUnitario)
        {
            bool R = false;
            CodigoBarras = pCodigoBarras;
            DescripcionProducto = pDescripcionProducto;
            CantidadEnStock = pCantidadEnStock;
            PrecioUnitario = pPrecioUnitario;
        

            return R;

        }

        public bool Editar(int pIDProducto, String pCodigoBarras, String pDescripcionProducto, decimal pCantidadEnStock, decimal pPrecioUnitario)
        {


            bool R = false;


            return R;
        }

        public bool Eliminar(int pIDUsuario)
        {


            bool R = false;


            return R;
        }
        public bool ConsultarPorCodigoDeBarras()
        {


            bool R = false;


            return R;
        }
        public Producto ConsultarPorID(int pIDProducto)
        {


            Producto R = new Producto();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@id", pIDProducto));
            DataTable Datos = new DataTable();

            Datos = MyCnn.EjecutarSelect("SpProductosConsultarPorID");


            if (Datos != null && Datos.Rows.Count > 0)
            {
                DataRow MisDatos = Datos.Rows[0];

                R.IDProducto = Convert.ToInt32(MisDatos["IDProducto"]);

                R.DescripcionProducto = Convert.ToString(MisDatos["DescripcionProducto"]);

                R.CantidadEnStock = Convert.ToDecimal(MisDatos["CantidadEnStock"]);

                R.PrecioUnitario = Convert.ToDecimal(MisDatos["PrecioUnitario"]);

                R.MiImpuesto.IDImpuesto = Convert.ToInt32(MisDatos["IDImpuesto"]);

                R.MiCategoria.IDProductoCategoria = Convert.ToInt32(MisDatos["IdProductoCategoria"]);
                R.MiunidadMedida.IDUnidad = Convert.ToInt32(MisDatos["IdUnidad"]);

                R.CodigoBarras = Convert.ToString(MisDatos["CodigoDeBarras"]);
             
                R.MiunidadMedida.Unidad = Convert.ToString(MisDatos["UnidadMedida"]);

                R.MiCategoria.Categoria = Convert.ToString(MisDatos["Categoria"]);

                R.MiImpuesto.CodigoImpuesto = Convert.ToString(MisDatos["CodigoImpuesto"]);
                R.MiImpuesto.ImpuestoNombre = Convert.ToString(MisDatos["ImpuestoNombre"]);
                R.MiImpuesto.MontoImpuesto = Convert.ToDecimal(MisDatos["MontoImpuesto"]);









            }

            return R;
        }
        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.EjecutarSelect("SpProductosListar");



            //datos necesarios
            return R;

        }
    }
}
