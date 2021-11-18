using System;
using System.Data;
using System.Data.SqlClient;
using Datos;
using Datos.Modelos;

namespace Logica
{
    public class ContactosCrud
    {
        private ContactosBD _contactos;

        public ContactosCrud(SqlConnection conexion)
        {
            _contactos = new ContactosBD(conexion);
        }

        public bool Agregar(Contactos contactos)
        {
            return _contactos.Agregar(contactos);
        }

        public bool Editar(Contactos contactos)
        {
            return _contactos.Editar(contactos);
        }

        public bool Eliminar(int id)
        {
            return _contactos.Eliminar(id);
        }

        public DataTable ObtenerTodo()
        {
            return _contactos.ObtenerTodo();
        }

        public Contactos ObtenerporID(int id)
        {
            return _contactos.ObtenerporID(id);
        }

    }
}
