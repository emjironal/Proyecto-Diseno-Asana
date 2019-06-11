using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                if (tarea.fchEntrega.ToString("yyyy-MM-dd") != "0001-01-01")
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"fchFinalizacion\", \"fchEntrega\", \"id_tareaPadre\", id_proyecto, nombre, nota) values ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, tarea.fchFinalizacion.ToString("yyyy-MM-dd"), tarea.fchEntrega.ToString("yyyy-MM-dd"), idPadre == null ? "null" : "'" + idPadre + "'", idProyecto, tarea.nombre, tarea.notas);
                }
                else
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"fchFinalizacion\", \"id_tareaPadre\", id_proyecto, nombre, nota) values ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, tarea.fchFinalizacion.ToString("yyyy-MM-dd"), idPadre == null ? "null" : "'" + idPadre + "'", idProyecto, tarea.nombre, tarea.notas);
                }
            }
            else
            {
                if (tarea.fchEntrega.ToString("yyyy-MM-dd") != "0001-01-01")
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"fchEntrega\", \"id_tareaPadre\", id_proyecto, nombre, nota) values ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, tarea.fchEntrega.ToString("yyyy-MM-dd"), idPadre == null ? "null" : "'" + idPadre + "'", idProyecto, tarea.nombre, tarea.notas);
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
            Object[][] resultSet = DbConnection.consultar(new Consulta().Select("*").From("Proyecto").Where(String.Format("id_proyecto = {0}",id)).Get(), 3);
            Proyecto proyecto = new Proyecto();
            try
            {
                String[] proyAttrib = Array.ConvertAll(resultSet[0], p => (p ?? String.Empty).ToString());
                proyecto.id = proyAttrib[0];
                proyecto.nombre = proyAttrib[1];
                Usuario administrador = DAOUsuario.consultarUsuario(proyAttrib[2]);
                if (administrador != null) {
                    administrador.isAdministrador = true;
                    proyecto.administradorProyecto = administrador;
                }
                asignarMiembros(proyecto);
                proyecto.secciones = consultarTarea(id);
            }
            catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            }
            

            return proyecto;
        }

        private static void asignarMiembros(Proyecto proyecto)
        {
            gestor.GestorBaseDatos DbConnection = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            Object[][] resultSet = DbConnection.consultar(new Consulta().Select("id_usuario").From("miembroporproyecto").Where(String.Format("id_proyecto = {0}", proyecto.id)).Get(), 1);
            for (int i = 0; i < resultSet.Count(); i++) {
                String[] result = Array.ConvertAll(resultSet[i], p => (p ?? String.Empty).ToString());
                Usuario u = DAOUsuario.consultarUsuario(result[0]);
                proyecto.miembros.Add(u);
            }
        }

        private static List<Tarea> consultarTarea(string proyecto)
        {
            gestor.GestorBaseDatos DbConnection = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            List<Tarea> result = new List<Tarea>();
            Object[][] tareas = DbConnection.consultar(new Consulta().Select("*").From("Tarea t")
                .Where(
                    String.Format("id_proyecto = {0} AND \"id_tareaPadre\" IS NULL AND EXISTS ({1})",proyecto,
                    new Consulta().Select("*").From("tareaporseccion ts").Where("t.id_tarea = ts.id_seccion").Get()))
                .OrderBy("t.nombre").Get(),8);
            for (int i = 0; i < tareas.Count(); i++) {
                String[] datosTarea = Array.ConvertAll(tareas[i], p => (p ?? String.Empty).ToString());
                Tarea t = new Tarea();
                Int64 id = 0;
                if (Int64.TryParse(datosTarea[0], out id))
                {
                    t.codigo = datosTarea[0];
                    t.tareas = consultarTareaHijas(id, proyecto, true); //RETORNA 0 SIEMPRE
                }
                Usuario encargado = DAOUsuario.consultarUsuario(datosTarea[1]);
                if (encargado == null)
                {
                    Console.WriteLine("tarea " + t.codigo + " no tiene encargado");
                }
                //TODO: Asignar Seguidores
                t.encargado = encargado;
                t.seguidores = asignarSeguidores(t.codigo);
                String[] fechaprueba = datosTarea[2].Split();
                DateTime fchEntrega, fchFinalizacion;
                if (DateTime.TryParseExact(datosTarea[2].Split()[0], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None,out fchEntrega)){
                    t.fchEntrega = fchEntrega;
                }
                if (DateTime.TryParseExact(datosTarea[3].Split()[0], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fchFinalizacion)) {
                    t.fchFinalizacion = fchFinalizacion;
                }
                t.nombre = datosTarea[4];
                t.notas = datosTarea[5];
                result.Add(t);
            }
            return result;
        }

        private static List<Usuario> asignarSeguidores(string codigo)
        {
            List<Usuario> seguidores = new List<Usuario>();
            gestor.GestorBaseDatos DbConnection = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            Object[][] resultSet = DbConnection.consultar(new Consulta().Select("id_usuario").From("seguidorportarea").Where(String.Format("id_tarea = {0}",codigo)).Get(), 1);
            for (int i = 0; i < resultSet.Count(); i++)
            {
                String[] result = Array.ConvertAll(resultSet[i], p => (p ?? String.Empty).ToString());
                Usuario u = DAOUsuario.consultarUsuario(result[0]);
                seguidores.Add(u);
            }
            return seguidores;
        }

        private static List<Tarea> consultarTareaHijas(long tareaPadre, string id_proyecto, bool isTarea)
        {
            gestor.GestorBaseDatos DbConnection = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            List<Tarea> result = new List<Tarea>();
            Object[][] tareas;
            if (isTarea)
            {
                tareas = DbConnection.consultar(new Consulta().Select("*").From("Tarea t")
                .Where(
                    String.Format("id_proyecto = {0} AND \"id_tareaPadre\" IS NULL AND EXISTS ({1})", id_proyecto,
                    new Consulta().Select("*").From("tareaporseccion ts")
                    .Where(String.Format("t.id_tarea = ts.id_tarea and ts.id_seccion = '{0}'",tareaPadre)).Get()))
                .OrderBy("t.id_tarea").Get(), 8);
            }
            else {
                tareas = DbConnection.consultar(new Consulta().Select("*").From("Tarea").Where(String.Format("\"id_tareaPadre\" = '{0}' ", tareaPadre)).Get(),8);
            }
            for (int i = 0; i < tareas.Count(); i++)
            {
                String[] datosTarea = Array.ConvertAll(tareas[i], p => (p ?? String.Empty).ToString());
                Tarea t = new Tarea();
                long id = 0;
                if (Int64.TryParse(datosTarea[0], out id))
                {
                    t.codigo = datosTarea[0];
                    if(isTarea)
                        t.tareas = consultarTareaHijas(id, id_proyecto, false);
                }
                Usuario encargado = DAOUsuario.consultarUsuario(datosTarea[1]);
                if (encargado == null)
                {
                    Console.WriteLine("tarea" + t.codigo + "no tiene encargado");
                }
                t.encargado = encargado;
                t.seguidores = asignarSeguidores(t.codigo);
                DateTime fchEntrega, fchFinalizacion;
                if (DateTime.TryParseExact(datosTarea[2].Split()[0], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fchEntrega))
                {
                    t.fchEntrega = fchEntrega;
                }
                if (DateTime.TryParseExact(datosTarea[3].Split()[0], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fchFinalizacion))
                {
                    t.fchFinalizacion = fchFinalizacion;
                }
                t.nombre = datosTarea[4];
                t.notas = datosTarea[5];
                result.Add(t);
            }
            return result;
        }

        private static List<Proyecto> consultarProyectos()
        {
            return null;
        }
    }
}
