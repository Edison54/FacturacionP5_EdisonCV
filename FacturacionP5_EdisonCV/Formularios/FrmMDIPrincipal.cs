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
            if (!ObjetosGlobales.MiFormDeGestionDeUsuarios.Visible)
            {
                ObjetosGlobales.MiFormDeGestionDeUsuarios= new FrmUsuariosGestion();
                ObjetosGlobales.MiFormDeGestionDeUsuarios.Show();

            }
        }

        private void listadoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMDIPrincipal_Load(object sender, EventArgs e)
        {

            string UsuarioLogeado = string.Format("{0}({1}) Rol: {2}", ObjetosGlobales.MiUsuarioGlobal.Nombre,
                ObjetosGlobales.MiUsuarioGlobal.NombreUsuario, ObjetosGlobales.MiUsuarioGlobal.MiRol.Rol);
            LblUsuarioLogeado.Text = UsuarioLogeado;

            //ahora revisamos el rol y si es facturador ocultamos ciertas opciones

            switch (ObjetosGlobales.MiUsuarioGlobal.MiRol.IDUsuarioRol)
            {
                case 1:
                    // Es admin no se bloquea nada
                    break;
                case 2:
                    //es un facturador se apagan varias opciones

                    MnuEmpresaGestion.Enabled = false;
                    MnuClientesGestion.Enabled = false;
                    MnuProductosGestion.Enabled = false;
                    MnuUsuariosGestion.Enabled = false;


                    break;

            }
            //EL TIMER
            TmrEstablecerFechaHora.Enabled = true;
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void TmrEstablecerFechaHora_Tick(object sender, EventArgs e)
        {
            LblFechaHora.Text = DateTime.Now.ToLongDateString() + " "+ DateTime.Now.ToShortTimeString();
        }
    }
}
