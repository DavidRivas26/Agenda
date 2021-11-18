using System;
using System.Data;
using System.Data.SqlClient;
using Datos;
using Datos.Modelos;

namespace Logica
{
    public class UsuariosCrud
    {

        private UsuariosBD _usuarios;

        public UsuariosCrud(SqlConnection conexion)
        {
            _usuarios = new UsuariosBD(conexion);
        }

        public bool Agregar(Usuarios usuarios)
        {
            return _usuarios.Agregar(usuarios);
        }

        public DataTable ObtenerTodo(string usuario, string contra)
        {
            return _usuarios.ObtenerTodo(usuario, contra);
        }
    }
}
