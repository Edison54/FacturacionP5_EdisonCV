using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.models
{
    internal class Producto
    {
        public int IDProducto { get; set; }

        public String CodigoBarras { get; set; }
        public String DescripcionProducto { get; set; }

        public decimal CantidadEnStock { get; set; }

        public decimal PrecioUnitario { get; set; }


        //Atributos Compuestos



        UnidadMedida MiunidadMedida { get; set; }
        ProductoCategoria MiCategoria { get; set; }
        Impuesto MiImpuesto { get; set; }

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
        public bool ConsultarPorID(int IDProducto)
        {


            bool R = false;


            return R;
        }
        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();




            //datos necesarios
            return R;

        }
    }
}
