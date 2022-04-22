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
    }
}
