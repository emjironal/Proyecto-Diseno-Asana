﻿using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.dao
{
    class DAOProyecto
    {
        public Boolean agregarProyecto(Proyecto proyecto)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            (new dao.DAOUsuario()).agregarUsuario(proyecto.administradorProyecto);
            db.conectar();
            string query = string.Format("insert into Proyecto values ('{0}', '{1}', '{2}')", proyecto.id, proyecto.nombre, proyecto.administradorProyecto.id);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            foreach (Usuario usuario in proyecto.miembros)
            {
                (new dao.DAOUsuario()).agregarUsuario(usuario);
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

        private void agregarTarea(Tarea tarea, Tarea seccion, Proyecto proyecto)
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

        public bool agregarMiembroPorProyecto(string idProyecto, string idUsuario)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into MiembroPorProyecto (id_proyecto, id_usuario) values ({0}, {1})";
            query = string.Format(query, idProyecto, idUsuario);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public bool agregarSeguidorPorTarea(string idUsuario, string idTarea)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into SeguidorPorTarea (id_usuario, id_tarea) values ({0}, {1})";
            query = string.Format(query, idUsuario, idTarea);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public bool agregarTareaPorProyecto(string idProyecto, string idTarea)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into TareaPorProyecto (id_tarea, id_proyecto) values ('{0}', '{1}')";
            query = string.Format(query, idTarea, idProyecto);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public Boolean agregarTareaASeccion(Tarea tarea, Tarea seccion)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into TareaPorSeccion (id_tarea, id_seccion) values ('{0}', '{1}')";
            query = string.Format(query, tarea.codigo, seccion.codigo);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public Boolean agregarTarea(Tarea tarea, string idPadre, string idProyecto)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            string query = "";
            if (tarea.isFinalizada)
            {
                if (tarea.fchEntrega.ToString("yyyy-mm-dd") != "0001-00-01")
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"fchFinalizacion\", \"fchEntrega\", \"id_tareaPadre\", id_proyecto) values ('{0}', '{1}', '{2}', '{3}', {4}, '{5}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, tarea.fchFinalizacion.ToString("yyyy-mm-dd"), tarea.fchEntrega.ToString("yyyy-mm-dd"), idPadre == null ? "null" : "'" + idPadre + "'", idProyecto);
                }
                else
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"fchFinalizacion\", \"id_tareaPadre\", id_proyecto) values ('{0}', '{1}', '{2}', {3}, '{4}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, tarea.fchFinalizacion.ToString("yyyy-mm-dd"), idPadre == null ? "null" : "'" + idPadre + "'", idProyecto);
                }
            }
            else
            {
                if (tarea.fchEntrega.ToString("yyyy-mm-dd") != "0001-00-01")
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"fchEntrega\", \"id_tareaPadre\", id_proyecto) values ('{0}', '{1}', '{2}', {3}, '{4}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, tarea.fchEntrega.ToString("yyyy-mm-dd"), idPadre == null ? "null" : "'" + idPadre + "'", idProyecto);
                }
                else
                {
                    query = "insert into Tarea (id_tarea, \"idEncargado\", \"id_tareaPadre\", id_proyecto) values ('{0}', '{1}', {2}, '{3}')";
                    query = string.Format(query, tarea.codigo, tarea.encargado == null ? "null" : tarea.encargado.id, idPadre == null ? "null" : "'" + idPadre + "'", idProyecto);
                }
            }
            db.conectar();
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        private Proyecto consultarProyecto(int id)
        {
            return null;
        }

        private List<Tarea> consultarTarea(int proyecto)
        {
            return null;
        }

        private List<Tarea> consultarTareaHijas(int tareaPadre)
        {
            return null;
        }

        private List<Proyecto> consultarProyectos()
        {
            return null;
        }
    }
}
