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
    public partial class FrmUsuariosGestion : Form
    {
        public FrmUsuariosGestion()
        {
            InitializeComponent();
        }

      
        private void ListarUsuariosActivos()
        {

        //paso 1 y 1.1 de SdUsuariosListarActivos
           Logica.models.Usuario Miusuario = new Logica.models.Usuario();

        //paso 2 y 2.5
        DataTable dt = Miusuario.ListarActivos();   
        //Mostrar datos en el dgv
        DgbListaUsuarios.DataSource = dt;


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuariosGestion_Load_1(object sender, EventArgs e)
        {
            ListarUsuariosActivos();
        }
    }
}
