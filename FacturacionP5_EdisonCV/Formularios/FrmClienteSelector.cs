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
    public partial class FrmClienteSelector : Form
    {
        DataTable ListaClientes = new DataTable();


        public Logica.models.Cliente MiCliente { get; set; }



        public FrmClienteSelector()
        {
            InitializeComponent();

            MiCliente = new Logica.models.Cliente();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmClienteSelector_Load(object sender, EventArgs e)
        {
        LlenarListaClientes();
        }

        private void LlenarListaClientes(string filtro = "")
        {
            ListaClientes = new DataTable();
            ListaClientes = MiCliente.Listar(true, filtro);
            DgvLista.DataSource = ListaClientes;

            DgvLista.ClearSelection();

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            if(DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvLista.SelectedRows[0];
                int IdCliente = Convert.ToInt32(Fila.Cells["CIDCliente"].Value);
                string Nombre = Convert.ToString(Fila.Cells["CNombre"].Value);
                string Telefono = Convert.ToString(Fila.Cells["CTelefono"].Value);

                ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.IDCliente = IdCliente;
                ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.Nombre = Nombre;
                ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.Telefono = Telefono;
                DialogResult = DialogResult.OK;
            }
           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            TmrBuscarCliente.Enabled = false;
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            TmrBuscarCliente.Enabled = true;
        }

        private void TmrBuscarCliente_Tick(object sender, EventArgs e)
        {

            TmrBuscarCliente.Enabled = false;

            if(!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                string Filtro = TxtBuscar.Text.Trim();

                LlenarListaClientes(Filtro);

            }
            else
            {
                LlenarListaClientes();

            }
        }

        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            DgvLista.ClearSelection();
        }
    }
}
