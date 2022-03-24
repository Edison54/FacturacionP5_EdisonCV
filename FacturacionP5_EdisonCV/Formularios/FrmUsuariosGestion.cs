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

        public Logica.models.Usuario MiUsuarioLocal { get; set; }
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

     

        private void FrmUsuariosGestion_Load_1(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormularioPrincipal;
            ListarUsuariosActivos();

            
            cargarRolesDeUsuarioEnCombo();
            LimpiarForm();
            ActivarAgregar();
            

        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;

        }

        private void ActivarEditarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;

        }

        private void LimpiarForm()
        {
            //Metodo que elimina limpia todos los datos del form
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtEmail.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtEmailRespaldo.Clear();  
            TxtPassword.Clear();
            CboxTipoUsuario.SelectedIndex = -1;

        }

        private void LimpiarEmails()
        {
            //Metodo que elimina limpia todos los datos del form
            
            TxtEmail.Clear();
           
            TxtEmailRespaldo.Clear();
          

        }

        private void Limpiarpassword()
        {
            //Metodo que elimina limpia todos los datos del form

            TxtPassword.Clear();


        }

        private bool ValidarDatosRequeridos()

         {
            bool R = false;
            if(!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtEmailRespaldo.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtPassword.Text.Trim()) &&
               CboxTipoUsuario.SelectedIndex > -1
               
               )
               {

                //validar la contra en agregar en caso que se digite cuando estemos en modo de edicion
                R = true;

            }
            else
            {
                //reroalimentar al usuario para que sepa que no digito algo.

                if(string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {
                    MessageBox.Show("El nombre del usuario es requerido", "Error de validacion" , MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("El email del usuario es requerido", "Error de validacion", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("La cedula del usuario es requerida", "Error de validacion", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
                {
                    MessageBox.Show("El  telefono del usuario es requerido", "Error de validacion", MessageBoxButtons.OK);
                    TxtTelefono.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtEmailRespaldo.Text.Trim()))
                {
                    MessageBox.Show("El  email de respaldo del usuario es requerido", "Error de validacion", MessageBoxButtons.OK);
                    TxtEmailRespaldo.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                {
                    MessageBox.Show("La contraseña del usuario es requerida", "Error de validacion", MessageBoxButtons.OK);
                    TxtPassword.Focus();
                    return false;
                }
                if (CboxTipoUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("El tipo de usuario es requerido", "Error de validacion", MessageBoxButtons.OK);
                    TxtPassword.Focus();
                    return false;
                }


            }


               


            return R;

         }










        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //en la secuencia no se llega a explicar pero hay que validar cosas
            //Datos minimos y de tipos y extenciones correctas para cada equipo
           if(ValidarDatosRequeridos())
            { 

                string Pregunta = string.Format("Esta seguro de agregar el usuario {0}" , TxtNombre.Text.Trim());
                DialogResult RespuestaDelUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDelUsuario == DialogResult.Yes)
                {
                    //Temporal : Se agregan los valores de lso atriburos del objeto local

                    MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                    MiUsuarioLocal.NombreUsuario = TxtEmail.Text.Trim();
                    MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
                    MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
                    MiUsuarioLocal.Contrasennia = TxtPassword.Text.Trim();
                    MiUsuarioLocal.CorreoDeRespaldo = TxtEmailRespaldo.Text.Trim();
                    MiUsuarioLocal.MiRol.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);
                    //paso 1.1 y 1.2 esta en el constructor
                    //paso 1.3 y 1.3.6
                    bool A = MiUsuarioLocal.ConsultarPorCedula();

                    //paso 1.4 y 1.4.6
                    bool B = MiUsuarioLocal.ConsultarPorEmail();

                    //paso 1.5

                    if (!A && !B)
                    {
                        if(!Validacion.IsValidEmail(MiUsuarioLocal.NombreUsuario) && !Validacion.IsValidEmail(MiUsuarioLocal.CorreoDeRespaldo))
                        {
                             MessageBox.Show("Los 2 emails deben tener un formato correcto", " !!!!!", MessageBoxButtons.OK);
                            LimpiarEmails();

                        }
                        else
                        {
                            if (!Validacion.ValidatePassword(MiUsuarioLocal.Contrasennia)) {
                                MessageBox.Show("La contraseña debe tener Letras mayusculas, minusculas,numerosa enteros y caracteres especiales", " !!!!!", MessageBoxButtons.OK);
                                Limpiarpassword();


                            }
                            else
                            {
                                //PASO 1.6 , 1.6.6 Y 1.7
                                if (MiUsuarioLocal.Agregar())
                                {
                                    MessageBox.Show("Usuario creado correctamente", " !!!!!", MessageBoxButtons.OK);


                                }
                                else
                                {
                                    MessageBox.Show("Hubo un error y no pudo guardarse", " :C", MessageBoxButtons.OK);
                                }
                                ListarUsuariosActivos();
                                LimpiarForm();
                            }
                        }
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
            
            }
        }

        private void DgbListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgbListaUsuarios.ClearSelection();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, true);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, true);
        }

        private void TxtEmailRespaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, false, true);
        }

      

        private void BtnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar();
        }

        private void DgbListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ESTE CODIGO ES PARA QUE AL TOCAR UNA LINEA DEL GRID , SE MUESTREN LOS DATOS DE ESE USUARIO EN EN FORMULARIO

            if (DgbListaUsuarios.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgbListaUsuarios.SelectedRows[0];

                int IdUsuarioSeleccionado = Convert.ToInt32(Fila.Cells["CIDUsuario"].Value);

                MiUsuarioLocal = new Logica.models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IdUsuarioSeleccionado);

                if(MiUsuarioLocal.IDUsuario > 0)
                {
                    //

                    LimpiarForm();

                    TxtCodigo.Text =MiUsuarioLocal.IDUsuario.ToString();
                    TxtNombre.Text = MiUsuarioLocal.Nombre;
                    TxtEmail.Text = MiUsuarioLocal.NombreUsuario;
                    TxtCedula.Text = MiUsuarioLocal.Cedula;
                    TxtTelefono.Text = MiUsuarioLocal.Telefono;
                    TxtEmailRespaldo.Text = MiUsuarioLocal.CorreoDeRespaldo;

                    CboxTipoUsuario.SelectedValue = MiUsuarioLocal.MiRol.IDUsuarioRol;


                    ActivarEditarYEliminar();
                }


            }
        }

        
    }
}
