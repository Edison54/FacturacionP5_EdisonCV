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
    public partial class FrmFacturacionItemGestion : Form
    {


        DataTable ListaItems { get; set; }


        Logica.models.Producto MiProducto { get; set; }



        public FrmFacturacionItemGestion()
        {
            InitializeComponent();



            ListaItems = new DataTable();
            MiProducto = new Logica.models.Producto();
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDescuento.Text.Trim()))
            {
                TxtDescuento.Text = "0";

                TxtDescuento.SelectAll();
            }
            else
            {

                CalcularPrecioFinal(MiProducto, Convert.ToDecimal(TxtDescuento.Text.Trim()));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DgvListaItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaItems.ClearSelection();
        }

        private void FrmFacturacionItemGestion_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }
        private void LlenarLista()
        {

            ListaItems = new DataTable();

            ListaItems = MiProducto.Listar();

            DgvListaItems.DataSource = ListaItems;

            DgvListaItems.ClearSelection();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarItem())
            {


                DataRow NuevaLineaDetalleFacturacion = ObjetosGlobales.MiFormFacturador.ListaDetallesLocal.NewRow();

                DataGridViewRow FilaSeleccionada = DgvListaItems.SelectedRows[0];

                NuevaLineaDetalleFacturacion["IDProducto"] = MiProducto.IDProducto;
                NuevaLineaDetalleFacturacion["DescripcionItem"] = MiProducto.DescripcionProducto;

                NuevaLineaDetalleFacturacion["CantidadFacturada"] = TxtCantidad.Value;

                NuevaLineaDetalleFacturacion["PorcentajeDescuento"] = Convert.ToDecimal(TxtDescuento.Text.Trim());



                //todo cargar atributos restantes

                NuevaLineaDetalleFacturacion["PrecioUnitario"] = MiProducto.PrecioUnitario;


             


                //calculo impuesto por linea

                decimal porcentajeDescuento = Convert.ToDecimal(TxtDescuento.Text.Trim());
                decimal PrecioMenosDescuento = MiProducto.PrecioUnitario - ((MiProducto.MiImpuesto.MontoImpuesto * porcentajeDescuento)/100);

                decimal Impuestos = ((PrecioMenosDescuento * MiProducto.MiImpuesto.MontoImpuesto) / 100) *TxtCantidad.Value;
       
                NuevaLineaDetalleFacturacion["ImpuestosLinea"] = Impuestos;


                decimal TotalLinea = PrecioMenosDescuento * TxtCantidad.Value + Impuestos;

                NuevaLineaDetalleFacturacion["TotalLinea"] = TotalLinea;


                NuevaLineaDetalleFacturacion["SubTotalLinea"] = TxtCantidad.Value * PrecioMenosDescuento;

                ObjetosGlobales.MiFormFacturador.ListaDetallesLocal.Rows.Add(NuevaLineaDetalleFacturacion);

                DialogResult = DialogResult.OK;


            }
        }


        private bool ValidarItem()
        {


            bool R = false;

            if(DgvListaItems.SelectedRows.Count == 1 && TxtCantidad.Value > 0)
            {

                R = true;
            }
            else
            {

                if(DgvListaItems.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un item de la lista", "Error validacion", MessageBoxButtons.OK);

                    return false;
                }
                if (TxtCantidad.Value == 0)
                {
                    MessageBox.Show("La cantidad no puede ser cero", "Error validacion", MessageBoxButtons.OK);

                    return false;
                }
            }
            return R;
        }

        private void CalcularPrecioFinal(Logica.models.Producto pProducto, decimal PorcentajeDeDescuento)
        {
            decimal PrecioConDescuento = pProducto.PrecioUnitario - ((pProducto.PrecioUnitario * PorcentajeDeDescuento) / 100);

            decimal PrecioConImpuesto = PrecioConDescuento + ((PrecioConDescuento * pProducto.MiImpuesto.MontoImpuesto) / 100);



                TxtPrecioFinal.Text = PrecioConImpuesto.ToString();

        }


        private void DgvListaItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvListaItems.SelectedRows.Count == 1)
            {
                DataGridViewRow FilaSeleccionada = DgvListaItems.SelectedRows[0];

                int IdProductoSeleccionado = Convert.ToInt32(FilaSeleccionada.Cells["CIDProducto"].Value);

                MiProducto = MiProducto.ConsultarPorID(IdProductoSeleccionado);

                if (MiProducto.IDProducto > 0)
                {
                    TxtIva.Text = MiProducto.MiImpuesto.MontoImpuesto.ToString();
                    TxtPrecioUnitario.Text = MiProducto.PrecioUnitario.ToString();


                    CalcularPrecioFinal(MiProducto, Convert.ToDecimal(TxtDescuento.Text.Trim()));

                }

            }
        }

        private void DgvListaItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
