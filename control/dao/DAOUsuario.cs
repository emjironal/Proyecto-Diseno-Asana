using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.dao
{
    static class DAOUsuario
    {
        public static Usuario consultarUsuario(String usr)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            Object[][] response = db.consultar(new Consulta().Select("*").From("usuario").Where(String.Format("id_usuario = '{0}'",usr)).Get(),6);
            if (response.Count() > 0)
            {
                Usuario user = new Usuario();
                String[] userData = Array.ConvertAll(response[0], p => (p ?? String.Empty).ToString());
                user.id = userData[0];
                user.nombre = userData[1];
                // userData[2] --> usuario
                user.contraseña = userData[3];
                user.correo = userData[4];
                user.isAdministrador = Boolean.Parse(userData[5]);
                return user;
            }
            else
            {
                return null;
            }
        }

        public static Boolean agregarUsuario(Usuario usr)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = string.Format("insert into Usuario (id_usuario, nombre) values ('{0}', '{1}')", usr.id, usr.nombre);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public static Boolean eliminarUsuario(String correo)
        {
            return true;
        }

        public static Boolean completarUsuario(Usuario usr)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = string.Format("update Usuario set correo = '{1}', is_administrador = {2} where (id_usuario = '{3}')", usr.correo,(usr.isAdministrador?"true" : "false"),usr.id);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }
    }
}
