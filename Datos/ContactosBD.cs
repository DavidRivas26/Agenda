using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Datos.Modelos;


namespace Datos
{
    public class ContactosBD
    {
        private SqlConnection _conexion;
        public ContactosBD(SqlConnection conexion)
        {
            _conexion = conexion;
        }

        public bool Agregar(Contactos contacto)
        {
 
            SqlCommand comando = new SqlCommand("insert into Contactos(Nombre, Apellido, Direccion, Telefono_Personal, Telefono_Trabajo) values(@nombre, @apellido, @direccion, @telefono_personal, @telefono_trabajo)", _conexion);

            comando.Parameters.AddWithValue("@nombre", contacto.Nombre);
            comando.Parameters.AddWithValue("@apellido", contacto.Apellido);
            comando.Parameters.AddWithValue("@direccion", contacto.Direccion);
            comando.Parameters.AddWithValue("@telefono_personal", contacto.Telefono_Personal);
            comando.Parameters.AddWithValue("@telefono_trabajo", contacto.Telefono_Trabajo);

            return EjecutarComando(comando);

        }

        public bool Editar(Contactos contacto)
        {

            SqlCommand comando = new SqlCommand("update Contactos set Nombre=@nombre, Apellido=@apellido, Direccion=@direccion, Telefono_Personal=@telefono_personal, Telefono_Trabajo=@telefono_trabajo where Id=@id", _conexion);

            comando.Parameters.AddWithValue("@id", contacto.Id);
            comando.Parameters.AddWithValue("@nombre", contacto.Nombre);
            comando.Parameters.AddWithValue("@apellido", contacto.Apellido);
            comando.Parameters.AddWithValue("@direccion", contacto.Direccion);
            comando.Parameters.AddWithValue("@telefono_personal", contacto.Telefono_Personal);
            comando.Parameters.AddWithValue("@telefono_trabajo", contacto.Telefono_Trabajo);

            return EjecutarComando(comando);

        }

        public bool Eliminar(int id)
        {

            SqlCommand comando = new SqlCommand("delete Contactos where Id=@id", _conexion);

            comando.Parameters.AddWithValue("@id", id);

            return EjecutarComando(comando);

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

        public DataTable ObtenerTodo()
        {

            SqlDataAdapter consulta = new SqlDataAdapter("select Id as Codigo, Nombre, Apellido, Direccion, Telefono_Personal, Telefono_Trabajo from Contactos", _conexion);
            return CargarDatos(consulta);

        }

        public Contactos ObtenerporID(int id)
        {

            try
            {

                _conexion.Open();

                SqlCommand comando = new SqlCommand("select Id, Nombre, Apellido, Direccion, Telefono_Personal, Telefono_Trabajo from Contactos where Id=@id", _conexion);
                
                comando.Parameters.AddWithValue("@id", id);

                SqlDataReader lector = comando.ExecuteReader();

                Contactos contacto = new Contactos();

                while (lector.Read())
                {

                    contacto.Id = lector.IsDBNull(0) ? 0 : lector.GetInt32(0);
                    contacto.Nombre = lector.IsDBNull(1) ? "" : lector.GetString(1); 
                    contacto.Apellido = lector.IsDBNull(2) ? "" : lector.GetString(2);
                    contacto.Direccion = lector.IsDBNull(3) ? "" : lector.GetString(3);
                    contacto.Telefono_Personal = lector.IsDBNull(4) ? "" : lector.GetString(4);
                    contacto.Telefono_Trabajo = lector.IsDBNull(5) ? "" : lector.GetString(5);

                }

                lector.Close();

                lector.Dispose();

                _conexion.Close();

                return contacto;

            }

            catch(Exception e)
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