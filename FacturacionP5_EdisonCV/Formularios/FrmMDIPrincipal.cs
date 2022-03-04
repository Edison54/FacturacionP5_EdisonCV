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
    public partial class FrmMDIPrincipal : Form
    {
        public FrmMDIPrincipal()
        {
            InitializeComponent();
        }

        private void gestioDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!ObjetosGlobales.MiFormDeGestionDeUsuarios.Visible)
            {
                ObjetosGlobales.MiFormDeGestionDeUsuarios = new FrmUsuariosGestion();
                ObjetosGlobales.MiFormDeGestionDeUsuarios.Show();
            }
        }

        private void listadoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
