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
        //Al igual que en todas las clases se puede escribir atributos para la misma.
        //en este casi  vamos a tener un atributo de tipo usuario de fondo
        //El cual me permite manipular los cambios que el usuario haga en todo momento

        public Logica.models.Usuario MiUsuarioLocal {get; set;}
        public FrmUsuariosGestion()
        {
            InitializeComponent();
            //paso 1.1 y 1.2
            MiUsuarioLocal = new Logica.models.Usuario();
        }
        
        private void cargarRolesDeUsuarioEnCombo()
        {

            //crear un objeto de tipo usuariorol

            Logica.models.UsuarioRol ObjRolDeUsuario = new Logica.models.UsuarioRol();

            DataTable ListaRoles = new DataTable();

            ListaRoles = ObjRolDeUsuario.Listar();

            CboxTipoUsuario.ValueMember = "id";

            CboxTipoUsuario.DisplayMember = "d";

            CboxTipoUsuario.DataSource = ListaRoles;
            CboxTipoUsuario.SelectedIndex = -1;
        }
      
        private void ListarUsuariosActivos()
        {

        //paso 1 y 1.1 de SdUsuariosListarActivos
           Logica.models.Usuario Miusuario = new Logica.models.Usuario();

        //paso 2 y 2.5
        DataTable dt = Miusuario.ListarActivos();   
        //Mostrar datos en el dgv
        DgbListaUsuarios.DataSource = dt;

            DgbListaUsuarios.ClearSelection();

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

            cargarRolesDeUsuarioEnCombo();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //en la secuencia no se llega a explicar pero hay que validar cosas
            //Datos minimos y de tipos y extenciones correctas para cada equipo
            //todo:Agregar funcionalidad validacion
            //Temporal : Se agregan los valores de lso atriburos del objeto local

            MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
            MiUsuarioLocal.NombreUsuario = TxtEmail.Text.Trim();
            MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
            MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
            MiUsuarioLocal.Contrasennia = TxtPassword.Text.Trim();
            MiUsuarioLocal.CorreoDeRespaldo = TxtEmailRespaldo.Text.Trim();
            MiUsuarioLocal.MiRol.IDUsuarioRol =  Convert.ToInt32(CboxTipoUsuario.SelectedValue);
            //paso 1.1 y 1.2 esta en el constructor
            //paso 1.3 y 1.3.6
            bool A = MiUsuarioLocal.ConsultarPorCedula();

            //paso 1.4 y 1.4.6
            bool B = MiUsuarioLocal.ConsultarPorEmail();

            //paso 1.5

            if(!A && !B)
            {
                //PASO 1.6 , 1.6.6 Y 1.7
                if (MiUsuarioLocal.Agregar())
                {
                    MessageBox.Show("Usuario creado correctamente" , " !!!!!" , MessageBoxButtons.OK);


                }
                else
                {
                    MessageBox.Show("Hubo un error y no pudo guardarse", " :C", MessageBoxButtons.OK);
                }
                ListarUsuariosActivos();
            }
            else
            {
                //
                if (A)
                {
                    MessageBox.Show("Ya existe un usuario con al cedula digitada", "Error de validacion", MessageBoxButtons.OK);
                }
                if (B)
                {
                    MessageBox.Show("Ya existe un usuario con el email digitado", "Error de validacion", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    TxtEmail.SelectAll();
                }
            }

        }

        private void DgbListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgbListaUsuarios.ClearSelection();
        }
    }
}
