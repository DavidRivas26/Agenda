using Datos.Modelos;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_10
{
    public partial class FrmRegistro : Form
    {
        private UsuariosCrud _usuarios;
        public int? id = null;

        public FrmRegistro()
        {
            InitializeComponent();

            string conexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection sql = new SqlConnection(conexion);

            _usuarios = new UsuariosCrud(sql);

        }

        #region Eventos

        private void lblLogin_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Validar();
        }


        #endregion

        #region Metodos

        private void Agregar()
        {

            Usuarios usuarios = new Usuarios();
            usuarios.Nombre = txtNombre.Text;
            usuarios.Apellido = txtApellido.Text;
            usuarios.Usuario = txtUsuario.Text;
            usuarios.Contra = txtContra.Text;
          

            bool resultado = _usuarios.Agregar(usuarios);

            if (resultado)
            {
                MessageBox.Show("Se ha registrado correctamente", "Aviso");
            }

            else
            {
                MessageBox.Show("Ha ocurrido un error", "Error");
            }

        }

        private void Validar()
        {


            if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellido.Text) && string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtContra.Text) && string.IsNullOrEmpty(txtConfirmarContra.Text))
            {

                MessageBox.Show("Debe llenar todos los campos", "Error");

            }
            else
            {

                if (txtContra.Text == txtConfirmarContra.Text)
                {

                    DataTable resultado = _usuarios.ObtenerTodo(txtUsuario.Text, txtContra.Text);

                    if (resultado.Rows[0][0].ToString() == "1")
                    {

                        MessageBox.Show("Este usuario ya esta creado", "Intente de nuevo");

                    }
                    else
                    {

                        Agregar();

                    }
                    
                }

                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error");
                }

            }

        }

        #endregion

    }
}
