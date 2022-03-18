using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionP5_EdisonCV
{
    public static class ObjetosGlobales
    {

        //Esta clase se autoistancia la momento de iniciar la aplicacion.
        //Los atributos y funciones que sean publicas seran
        //totalmente visibles para la aplicacion (Seran globales)

        public static Form MiFormularioPrincipal = new Formularios.FrmMDIPrincipal();

        public static Formularios.FrmUsuariosGestion MiFormDeGestionDeUsuarios = new Formularios.FrmUsuariosGestion();
    }
}
