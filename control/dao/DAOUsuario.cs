using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.dao
{
    class DAOUsuario
    {
        public Boolean consultarUsuario(Usuario usr)
        {
            return true;
        }

        public Boolean agregarUsuario(Usuario usr)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos();
            string query = string.Format("insert into Usuario (id_usuario, nombre) values ('{0}', '{1}')", usr.id, usr.nombre);
            return db.executeNonQuery(query); ;
        }

        public Boolean eliminarUsuario(String correo)
        {
            return true;
        }
    }
}
