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
            db.conectar();
            foreach(Usuario usuario in proyecto.miembros)
            {
                (new dao.DAOUsuario()).agregarUsuario(usuario);
                agregarMiembroPorProyecto(usuario.id, proyecto.id);
            }
            string query = string.Format("insert into Proyecto values ('{0}', '{1}', '{2}')", proyecto.id, proyecto.administradorProyecto.id, proyecto.nombre);
            db.executeNonQuery(query);
            foreach (Tarea seccion in proyecto.secciones)
            {
                if(seccion.codigo != null)
                {
                    agregarTarea(seccion, null);
                    agregarTareaPorProyecto(proyecto.id, seccion.codigo);
                }
                foreach(Tarea tarea in seccion.tareas)
                {
                    agregarTarea(tarea, seccion, proyecto);
                }
            }
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        private void agregarTarea(Tarea tarea, Tarea seccion, Proyecto proyecto)
        {
            agregarTarea(tarea, null);
            agregarTareaPorProyecto(proyecto.id, tarea.codigo);
            if (seccion.codigo != null)
                agregarTareaASeccion(tarea, seccion);
            foreach (Tarea subtarea in tarea.tareas)
            {
                agregarTarea(tarea, tarea.codigo);
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
            string query = "insert MiembroPorProyecto values ({0}, {1})";
            query = string.Format(query, idUsuario, idProyecto);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public bool agregarSeguidorPorTarea(string idUsuario, string idTarea)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert SeguidorPorTarea values ({0}, {1})";
            query = string.Format(query, idUsuario, idTarea);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public bool agregarTareaPorProyecto(string idProyecto, string idTarea)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into TareaPorProyecto (idTarea, idProyecto) values ('{0}', '{1}')";
            query = string.Format(query, idTarea, idProyecto);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public Boolean agregarTareaASeccion(Tarea tarea, Tarea seccion)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into TareaPorSeccion (idTarea, idSeccion) values ('{0}', '{1}')";
            query = string.Format(query, tarea.codigo, seccion.codigo);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public Boolean agregarTarea(Tarea tarea, string idPadre)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into Tarea (id_tarea, idEncargado {3} {4}, idTareaPadre) values ('{0}', '{1}' {5} {6}, {7})";
            if (tarea.isFinalizada)
            {
                if (tarea.fchEntrega != null)
                {
                    query = string.Format(query, tarea.codigo, tarea.encargado.id, ", fchFinalizacion", ", fchEntrega", ",'" + tarea.fchFinalizacion.ToString("yyyy-mm-dd") + "'", ",'" + tarea.fchEntrega.ToString("yyyy-mm-dd") + "'", idPadre);
                }
                else
                {
                    query = string.Format(query, tarea.codigo, tarea.encargado.id, ", fchFinalizacion", "", ",'" + tarea.fchFinalizacion.ToString("yyyy-mm-dd") + "'", "", idPadre);
                }
            }
            else
            {
                if (tarea.fchEntrega != null)
                {
                    query = string.Format(query, tarea.codigo, tarea.encargado.id, "", ", fchEntrega", "", ",'" + tarea.fchEntrega.ToString("yyyy-mm-dd") + "'", idPadre);
                }
                else
                {
                    query = string.Format(query, tarea.codigo, tarea.encargado.id, "", "", "", "", idPadre);
                }
            }
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
    }
}
