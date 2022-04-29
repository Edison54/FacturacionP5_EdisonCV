using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionP5_EdisonCV.Formularios
{
    public partial class FrmFacturacion : Form
    {

        public Logica.models.Factura FacturaLocal { get; set; }


        public DataTable ListaDetallesLocal { get; set; }


        public FrmFacturacion()
        {
            InitializeComponent();
            FacturaLocal = new Logica.models.Factura();

            ListaDetallesLocal = new DataTable();

        }


        private void Totalizar()
        {
            if (ListaDetallesLocal != null && ListaDetallesLocal.Rows.Count >0)
            {



                decimal subt = 0;

                decimal Descuentos = 0;
                decimal Impuestos = 0;

                decimal Total = 0;

                foreach (DataRow item in ListaDetallesLocal.Rows)
                {
                    subt += Convert.ToDecimal(item["CantidadFacturada"]) * Convert.ToDecimal(item["PrecioUnitario"]);

                    Descuentos += subt* Convert.ToDecimal(item["PorcentajeDescuento"]) /100 ;


                    Impuestos = +Convert.ToDecimal(item["ImpuestosLinea"]);


                    Total += Convert.ToDecimal(item["TotalLinea"]);


                }

                LblSubTotal.Text = string.Format("{0:N2}", subt);

                LblDescuentos.Text = string.Format("{0:N2}", Descuentos);

                LblImpuestos.Text = string.Format("{0:N2}", Impuestos);


                LblTotal.Text = string.Format("{0:N2}", Total);




            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormularioPrincipal;

            CargarComboEmpresas();
            CargarComboUsuarios();
            CargarComboFacturaTipos();
            Limpiar();
        }








        private void Limpiar()
        {
            CboxUsuario.SelectedValue = ObjetosGlobales.MiUsuarioGlobal.IDUsuario;

            CboxTipoFactura.SelectedItem = -1;
            DtpFechaFactura.Value = DateTime.Now.Date;

            TxtAnotaciones.Clear();

            LblSubTotal.Text = "0";
            LblDescuentos.Text = "0";
            LblImpuestos.Text = "0";
            LblTotal.Text = "0";

            FacturaLocal = new Logica.models.Factura();


            ListaDetallesLocal = new DataTable();
            ListaDetallesLocal = FacturaLocal.AsignarEsquemaDetalle();

            DgvListaItems.DataSource = ListaDetallesLocal;

            TxtIdCliente.Clear();
            LblNombreCliente.Text = "";
        }

        private void  CargarComboUsuarios()
        {
            CboxUsuario.DisplayMember = "Nombre";
            CboxUsuario.ValueMember = "IDUsuario";

            CboxUsuario.DataSource = FacturaLocal.MiUsuario.ListarActivos();

            CboxUsuario.SelectedIndex = -1;
        }

        private void CargarComboEmpresas()
        {
            CboxEmpresa.DisplayMember = "desc";
            CboxEmpresa.ValueMember = "id";

            CboxEmpresa.DataSource = FacturaLocal.MiEmpresa.Listar();

            CboxEmpresa.SelectedIndex = -1;
        }


        private void CargarComboFacturaTipos()
        {
            CboxTipoFactura.DisplayMember = "desc";
            CboxTipoFactura.ValueMember = "id";

            CboxTipoFactura.DataSource = FacturaLocal.MiTipo.Listar();

            CboxTipoFactura.SelectedIndex = -1;
        }

        private void TxtIdCliente_DoubleClick(object sender, EventArgs e)
        {
            Form MiFormBuscarCliente = new Formularios.FrmClienteSelector();


            DialogResult respuesta = MiFormBuscarCliente.ShowDialog();

            if(respuesta == DialogResult.OK)
            {

                LblNombreCliente.Text = FacturaLocal.MiCliente.Nombre;
                TxtIdCliente.Text = FacturaLocal.MiCliente.IDCliente.ToString();

            }
            else { LblNombreCliente.Text = ""; }
        }

        private void TxtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnItemAgregar_Click(object sender, EventArgs e)
        {
            Form FormSeleccionItem = new FrmFacturacionItemGestion();

            DialogResult resp = FormSeleccionItem.ShowDialog();

            if(resp == DialogResult.OK)
            {

                DgvListaItems.DataSource = ListaDetallesLocal;
             

                Totalizar();
            }
        }


        private void cargarDetalleDeFactura()
        {
            foreach(DataRow item in ListaDetallesLocal.Rows)
            {


                Logica.models.FacturaDetalle detalle = new Logica.models.FacturaDetalle();

                detalle.CantidadFacturada = Convert.ToDecimal(item["CantidadFacturada"]);
                detalle.DescripcionItem = Convert.ToString(item["DescripcionItem"]);
                detalle.impuerstosLinea = Convert.ToDecimal(item["ImpuestosLinea"]);
                detalle.MiProducto.IDProducto = Convert.ToInt32(item["IDProducto"]);
                detalle.PorcentajeDescuento = Convert.ToDecimal(item["PorcentajeDescuento"]);

                detalle.PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"]);
                detalle.SubtotalLinea = Convert.ToDecimal(item["SubtotalLinea"]);
                detalle.TotalLinea = Convert.ToDecimal(item["TotalLinea"]);


                FacturaLocal.DetalleItems.Add(detalle);



            }


        }
        private void BtnFacturar_Click(object sender, EventArgs e)
        {



            if(ListaDetallesLocal != null && ListaDetallesLocal.Rows.Count > 0)
            {


                FacturaLocal.MiCliente.IDCliente = Convert.ToInt32(TxtIdCliente.Text.Trim());
                FacturaLocal.MiTipo.IDFacturaTipo = Convert.ToInt32(CboxTipoFactura.SelectedValue);
                FacturaLocal.MiUsuario.IDUsuario = Convert.ToInt32(CboxUsuario.SelectedValue);
                FacturaLocal.MiEmpresa.IDEmpresa = Convert.ToInt32(CboxEmpresa.SelectedValue);
                FacturaLocal.Fecha = DtpFechaFactura.Value.Date;

                FacturaLocal.Anotaciones = TxtAnotaciones.Text.Trim();

                cargarDetalleDeFactura();

                if (FacturaLocal.Agregar())
                {
                    MessageBox.Show("FacturaGuardada Correctamente","siuuuu",MessageBoxButtons.OK);

                    Limpiar();
                }

            }
        }
    }
}
