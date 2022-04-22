﻿using System;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //Si la combinacion de teclas es adecueda muestra el boton de ingreso correcto

            if(e.Shift & e.KeyCode == Keys.CapsLock)
            {

                BtnIngresoDirecto.Visible = true;
            }
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            //ACA TENEMOS QUE HACER A UN USUARIO GLOBAL QUE NOS PEMITA INICIAR Y USAR LAS FUNCIONES DEL SISTEMA
            ObjetosGlobales.MiFormularioPrincipal.Show();
            this.Hide();

        }

        private void PbVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void PbVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }


        private bool ValidarDatosRequeridos()
        {
            bool R=  false;

            if(!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) && !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()) &&
                Validacion.IsValidEmail(TxtUsuario.Text.Trim()))

            {

                R = true;


            }
            else
            {
                if (string.IsNullOrEmpty(TxtUsuario.Text.Trim()))
                {
                    MessageBox.Show("Falta el nombre del usuario","Error validacion", MessageBoxButtons.OK);
                    TxtUsuario.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Falta la contraseña", "Error validacion", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    return false;
                }
                if (!Validacion.IsValidEmail(TxtUsuario.Text.Trim()))
                {
                    MessageBox.Show("El nombre de usuario no tiene un formato correcto", "Error validacion", MessageBoxButtons.OK);
                    TxtUsuario.Focus();
                    TxtUsuario.SelectAll();
                    return false;
                }

            }
            return R;
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                //existe usuario y password

                Logica.models.Usuario MiUsuario = new Logica.models.Usuario();
                string user = TxtUsuario.Text.Trim();
                string password = TxtContrasennia.Text.Trim();
                ObjetosGlobales.MiUsuarioGlobal = MiUsuario.ValidarIngreso(user, password);

                if (ObjetosGlobales.MiUsuarioGlobal != null
                    && ObjetosGlobales.MiUsuarioGlobal.IDUsuario > 0)
                {
                    //El usario puede iniciar al sistema
                    ObjetosGlobales.MiFormularioPrincipal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "error validacion", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    TxtContrasennia.SelectAll();


                }


            }

        }

        private void PbVerPassword_Click(object sender, EventArgs e)
        {

        }

        private void TxtContrasennia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
