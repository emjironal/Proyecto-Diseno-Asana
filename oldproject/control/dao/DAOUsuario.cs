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
            string query = string.Format("update Usuario set correo = '{0}', is_administrador = {1} where (id_usuario = '{2}')", usr.correo,(usr.isAdministrador?"true" : "false"),usr.id);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public static List<Usuario> consultarUsuarios()
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            Object[][] response = db.consultar(new Consulta().Select("id_usuario,nombre").From("usuario").Get(), 2);
            List<Usuario> usuarios = new List<Usuario>();
            for (int i = 0; i < response.Count(); i++)
            {
                Usuario usr = new Usuario();
                String[] result = Array.ConvertAll(response[i], p => (p ?? String.Empty).ToString());
                usr.id = result[0];
                usr.nombre = result[1];
                usuarios.Add(usr);
            }
            return usuarios;
        }
    }
}
