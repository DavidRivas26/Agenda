using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Datos.Modelos;

namespace Datos
{
    public class UsuariosBD
    {

        private SqlConnection _conexion;
        public UsuariosBD(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public bool Agregar(Usuarios usuario)
        {

            SqlCommand comando = new SqlCommand("insert into Usuarios (Nombre, Apellido, Nombre_Usuario, Contra) values (@nombre, @apellido, @usuario, @contra)", _conexion);

            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@contra", usuario.Contra);

            return EjecutarComando(comando);

        }

        public DataTable ObtenerTodo(string usuario, string contra)
        {

            SqlDataAdapter consulta = new SqlDataAdapter("select count(*) from Usuarios where Nombre_Usuario=@usuario or Contra=@contra", _conexion);
            consulta.SelectCommand.Parameters.AddWithValue("@usuario", usuario);
            consulta.SelectCommand.Parameters.AddWithValue("@contra", contra);

            return CargarDatos(consulta);
          
        }

        private DataTable CargarDatos(SqlDataAdapter consulta)
        {

            try
            {

                DataTable datos = new DataTable();

                _conexion.Open();

                consulta.Fill(datos);

                _conexion.Close();

                return datos;

            }

            catch (Exception e)
            {

                return null;

            }

        }

        public bool EjecutarComando(SqlCommand consulta)
        {

            try
            {

                _conexion.Open();

                consulta.ExecuteNonQuery();

                _conexion.Close();

                return true;

            }

            catch (Exception e)
            {

                return false;

            }
        }

    }
}
