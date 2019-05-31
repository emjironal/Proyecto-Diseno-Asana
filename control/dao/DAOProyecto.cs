using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.dao
{
    static class DAOProyecto
    {
        public static Boolean agregarProyecto(Proyecto proyecto)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            DAOUsuario.agregarUsuario(proyecto.administradorProyecto);
            db.conectar();
            string query = string.Format("insert into Proyecto values ('{0}', '{1}', '{2}')", proyecto.id, proyecto.nombre, proyecto.administradorProyecto.id);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            foreach (Usuario usuario in proyecto.miembros)
            {
                DAOUsuario.agregarUsuario(usuario);
                result &= agregarMiembroPorProyecto(proyecto.id, usuario.id);
            }
            foreach (Tarea seccion in proyecto.secciones)
            {
                if(seccion.codigo != null)
                {
                    result &= agregarTarea(seccion, null, proyecto.id);
                    result &= agregarTareaPorProyecto(proyecto.id, seccion.codigo);
                }
                foreach(Tarea tarea in seccion.tareas)
                {
                    agregarTarea(tarea, seccion, proyecto);
                }
            }
            return result;
        }

        private static void agregarTarea(Tarea tarea, Tarea seccion, Proyecto proyecto)
        {
            agregarTarea(tarea, null, proyecto.id);
            agregarTareaPorProyecto(proyecto.id, tarea.codigo);
            if (seccion.codigo != null)
                agregarTareaASeccion(tarea, seccion);
            foreach (Tarea subtarea in tarea.tareas)
            {
                agregarTarea(subtarea, tarea.codigo, proyecto.id);
                agregarTareaPorProyecto(proyecto.id, subtarea.codigo);
                foreach (Usuario usuario in subtarea.seguidores)
                {
                    agregarSeguidorPorTarea(usuario.id, subtarea.codigo);
                }
            }
            foreach (Usuario usuario in tarea.seguidores)
            {
                agregarSeguidorPorTarea(usuario.id, tarea.codigo);
            }
        }

        public static bool agregarMiembroPorProyecto(string idProyecto, string idUsuario)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into MiembroPorProyecto (id_proyecto, id_usuario) values ({0}, {1})";
            query = string.Format(query, idProyecto, idUsuario);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public static bool agregarSeguidorPorTarea(string idUsuario, string idTarea)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into SeguidorPorTarea (id_usuario, id_tarea) values ({0}, {1})";
            query = string.Format(query, idUsuario, idTarea);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public static bool agregarTareaPorProyecto(string idProyecto, string idTarea)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into TareaPorProyecto (id_tarea, id_proyecto) values ('{0}', '{1}')";
            query = string.Format(query, idTarea, idProyecto);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public static Boolean agregarTareaASeccion(Tarea tarea, Tarea seccion)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into TareaPorSeccion (id_tarea, id_seccion) values ('{0}', '{1}')";
            query = string.Format(query, tarea.codigo, seccion.codigo);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public static Boolean agregarTarea(Tarea tarea, string idPadre, string idProyecto)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            string query = "";
            if (tarea.isFinalizada)
            {
                if (tarea.fchEntrega.ToString("yyyy-mm-dd") != "0001-00-01")
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"fchFinalizacion\", \"fchEntrega\", \"id_tareaPadre\", id_proyecto, nombre, nota) values ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, tarea.fchFinalizacion.ToString("yyyy-mm-dd"), tarea.fchEntrega.ToString("yyyy-mm-dd"), idPadre == null ? "null" : "'" + idPadre + "'", idProyecto, tarea.nombre, tarea.notas);
                }
                else
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"fchFinalizacion\", \"id_tareaPadre\", id_proyecto, nombre, nota) values ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, tarea.fchFinalizacion.ToString("yyyy-mm-dd"), idPadre == null ? "null" : "'" + idPadre + "'", idProyecto, tarea.nombre, tarea.notas);
                }
            }
            else
            {
                if (tarea.fchEntrega.ToString("yyyy-mm-dd") != "0001-00-01")
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"fchEntrega\", \"id_tareaPadre\", id_proyecto, nombre, nota) values ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, tarea.fchEntrega.ToString("yyyy-mm-dd"), idPadre == null ? "null" : "'" + idPadre + "'", idProyecto, tarea.nombre, tarea.notas);
                }
                else
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"id_tareaPadre\", id_proyecto, nombre, nota) values ('{0}', '{1}', {2}, '{3}', '{4}', '{5}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, idPadre == null ? "null" : "'" + idPadre + "'", idProyecto, tarea.nombre, tarea.notas);
                }
            }
            db.conectar();
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public static Proyecto consultarProyecto(String id)
        {
            gestor.GestorBaseDatos DbConnection = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            String[] proyAttrib = ((String[][]) DbConnection.consultar(new Consulta().Select("*").From("Proyecto").Where(String.Format("id_proyecto = '{0}'",id)).Get(), 3))[0];
            Proyecto proyecto = new Proyecto();
            try
            {
                //
                proyecto.id = proyAttrib[0];
                //Usuario administrador = DAOUsuario.consultarUsuario()
                //proyecto.administradorProyecto = 
            }
            catch (Exception e) {

            }
            

            return null;
        }

        private static List<Tarea> consultarTarea(int proyecto)
        {
            return null;
        }

        private static List<Tarea> consultarTareaHijas(int tareaPadre)
        {
            return null;
        }

        private static List<Proyecto> consultarProyectos()
        {
            return null;
        }
    }
}
