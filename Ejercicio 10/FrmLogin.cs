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
    public partial class FrmLogin : Form
    {
        private UsuariosCrud _usuarios;
        public int? id = null;

        public FrmLogin()
        {
            InitializeComponent();

            string conexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection sql = new SqlConnection(conexion);

            _usuarios = new UsuariosCrud(sql);

        }

        #region Eventos

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        #endregion

        #region Metodos

        private void Validar()
        {


            if (string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtContra.Text))
            {

                MessageBox.Show("Debe llenar todos los campos", "Error");

            }

            else
            {

                DataTable resultado = _usuarios.ObtenerTodo(txtUsuario.Text, txtContra.Text);

                if(resultado.Rows[0][0].ToString() == "1")
                {

                    FrmInicio.Singleton.Show();

                }
                else
                {

                    MessageBox.Show("Datos incorrectos", "Intente de nuevo");

                }


            }
        }

        #endregion


    }
}
