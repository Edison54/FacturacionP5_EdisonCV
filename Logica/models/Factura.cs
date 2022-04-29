using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.models
{
    public class Factura
    {
        public int IDFactura { get; set; }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
       

        public decimal SubTotal { get; set; }

        public decimal Descuentos { get; set; }

        public decimal SubTotal2 { get; set; }
        public decimal Impuestos { get; set; }

        public decimal Total { get; set; }

        public string Anotaciones { get; set; }

        //compuestos
        public FacturaTipo MiTipo { get; set; }
        public Empresa MiEmpresa { get; set; }


        public Cliente MiCliente { get; set; }
        public Usuario MiUsuario { get; set; }

       //Compuesto multiple

        public List<FacturaDetalle> DetalleItems { get; set; }

        //constructor de la clases
        public Factura()
        {

            //Aqui debemos instanciar MiTipo

            MiTipo = new FacturaTipo();
            MiEmpresa = new Empresa();

            MiCliente = new Cliente();
            MiUsuario = new Usuario();
            DetalleItems = new List<FacturaDetalle>();

        }


        //Comportamientos?


        public bool Agregar()
        {

            bool R = false;


            Conexion MyCnnEncabezado = new Conexion();

            Totalizar();

            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@numero", this.Numero));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@fecha", this.Fecha));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@subTotal", this.SubTotal));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@Descuentos", this.Descuentos));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@subTotal2", this.SubTotal2));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@impuestos", this.Impuestos));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@total", this.Total));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@notas", this.Anotaciones));

            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@idtipo", this.MiTipo.IDFacturaTipo));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@idcliente", this.MiCliente.IDCliente));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@idususario", this.MiUsuario.IDUsuario));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@idempresa", this.MiEmpresa.IDEmpresa));



            Object Retorno = MyCnnEncabezado.EjecutarConRetornoEscalar("SpFacturaAgregarEncabezado");

            int IdFacturaRecienCreada = 0;

            if (Retorno !=null)
            {
                IdFacturaRecienCreada = Convert.ToInt32(Retorno.ToString());



                foreach (FacturaDetalle item in this.DetalleItems)
                {
                    //se hace un insert por cada interacion
                    Conexion MyCnnDetalle = new Conexion();

                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@idFactura", IdFacturaRecienCreada));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@idProducto", item.MiProducto.IDProducto));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@descripcion", item.DescripcionItem));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@cantidad", item.CantidadFacturada));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@precio", item.PrecioUnitario));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@porcentajedescuento", item.PorcentajeDescuento));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@subtotallinea", item.SubtotalLinea));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@impuestolinea", item.impuerstosLinea));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@totallinea", item.TotalLinea));


                    MyCnnDetalle.EjecutarUpdateDeleteInsert("SpFacturaAgregarDetalle");



                }

                R = true;
            }




            return R;

        }
        public DataTable ConsultarPorNumero(int pNumeroFactura)
        {
            DataTable R = new DataTable();

       


            return R;
        }
        public DataTable ListarPorRangoDeFechas(DateTime pFechaInicial, DateTime pFechaFinal )
        {
            DataTable R = new DataTable();




            return R;
        }
        public DataTable ListarPorUsuario(int pIDUsuario)
        {
            DataTable R = new DataTable();




            return R;
        }

        private void Totalizar()
        {
            //Asignar rubros decimales

            this.Numero = 10;// TODO PARA AUMENTAR NUMERO

            this.SubTotal = 0;
            this.SubTotal2 = 0;
            this.Descuentos = 0;
            this.Impuestos = 0;
            this.Total = 0;
        }

        public DataTable AsignarEsquemaDetalle()
        {
            DataTable R = new DataTable();
            Conexion MyCnn = new Conexion();

            R = MyCnn.EjecutarSelect("SpFacturasaDetalleEsquema", true);

            R.PrimaryKey = null;

            return R;
        }

    }
}
