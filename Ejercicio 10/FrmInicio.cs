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
    public sealed partial class FrmInicio : Form
    {
        private ContactosCrud _contactos;
        public int? id = null;
        public static FrmInicio Singleton { get; } = new FrmInicio();

        private FrmInicio()
        {
            InitializeComponent();

            string conexion = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection sql = new SqlConnection(conexion);

            _contactos = new ContactosCrud(sql);

        }

        #region Eventos

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellido.Text) && string.IsNullOrEmpty(txtDireccion.Text) && string.IsNullOrEmpty(txtTelefonoPersonal.Text) && string.IsNullOrEmpty(txtTelefonoTrabajo.Text))
            {
                MessageBox.Show("Debe llenar todos los campos", "Aviso");
            }

            else
            {
                if (id == null)
                {
                    Agregar();
                }
                else
                {
                    Editar();
                }
            }
        }

        private void msCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnDeseleccionar.Visible = true;

                Contactos contactos = new Contactos();

                contactos = _contactos.ObtenerporID(id.Value);

                txtNombre.Text = contactos.Nombre;
                txtApellido.Text = contactos.Apellido;
                txtDireccion.Text = contactos.Direccion;
                txtTelefonoPersonal.Text = contactos.Telefono_Personal;
                txtTelefonoTrabajo.Text = contactos.Telefono_Trabajo;

            }
        }

        #endregion

        #region Metodos

        private void Agregar()
        {
           
            Contactos contactos = new Contactos();
            contactos.Nombre = txtNombre.Text;
            contactos.Apellido = txtApellido.Text;
            contactos.Direccion = txtDireccion.Text;
            contactos.Telefono_Personal = txtTelefonoPersonal.Text;
            contactos.Telefono_Trabajo = txtTelefonoTrabajo.Text;

            bool resultado = _contactos.Agregar(contactos);

            if (resultado)
            {
                MessageBox.Show("Se ha agregado correctamente", "Aviso");
            }

            else
            {
                MessageBox.Show("Ha ocurrido un error", "Error");
            }

            CargarDatos();
            LimpiarDatos();
            Deseleccionar();
            

        }

        private void Editar()
        {

            Contactos contactos = new Contactos();
            contactos.Nombre = txtNombre.Text;
            contactos.Apellido = txtApellido.Text;
            contactos.Direccion = txtDireccion.Text;
            contactos.Telefono_Personal = txtTelefonoPersonal.Text;
            contactos.Telefono_Trabajo = txtTelefonoTrabajo.Text;
            contactos.Id = id.Value;

            bool resultado = _contactos.Editar(contactos);

            if (resultado)
            {
                MessageBox.Show("Se ha editado correctamente", "Aviso");
            }

            else
            {
                MessageBox.Show("Ha ocurrido un error", "Error");
            }

            CargarDatos();
            LimpiarDatos();
            Deseleccionar();

        }

        private void Eliminar()
        {
            
            if(id == null)
            {
                MessageBox.Show("Debe seleccionar un contacto", "Error");
            }

            else
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar este contacto?", "Advertencia", MessageBoxButtons.OKCancel);

                if(respuesta == DialogResult.OK)
                {
                    
                    bool resultado = _contactos.Eliminar(id.Value);

                    if (resultado)
                    {
                        MessageBox.Show("Se ha eliminado correctamente", "Aviso");
                    }

                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Error");
                    }

                    CargarDatos();
                    Deseleccionar();

                }
            }

        }

        private void CargarDatos()
        {
            dgvContactos.DataSource = _contactos.ObtenerTodo();
            dgvContactos.ClearSelection();
        }

        private void LimpiarDatos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefonoPersonal.Clear();
            txtTelefonoTrabajo.Clear();
        }

        private void Deseleccionar()
        {
            dgvContactos.ClearSelection();
            btnDeseleccionar.Visible = false;
            id = null;
            LimpiarDatos();
        }



        #endregion

    }
}
