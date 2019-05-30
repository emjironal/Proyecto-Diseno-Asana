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
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = string.Format("insert into Usuario (id_usuario, nombre) values ('{0}', '{1}')", usr.id, usr.nombre);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public Boolean eliminarUsuario(String correo)
        {
            return true;
        }
    }
}
