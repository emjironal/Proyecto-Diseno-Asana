using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.dao
{
    class DAOProyecto
    {
        public DAOProyecto() {
            gestor.GestorBaseDatos gestor = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            gestor.conectar();
        }


        public Boolean agregarProyecto(Proyecto proyecto)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos();
            (new dao.DAOUsuario()).agregarUsuario(proyecto.administradorProyecto);
            string query = string.Format("insert into Proyecto values ('{0}', '{1}', '{2}')", proyecto.id, proyecto.administradorProyecto.id, proyecto.nombre);
            db.executeNonQuery(query);
            foreach (Tarea seccion in proyecto.secciones)
            {
                agregarTarea(seccion, null);
            }
            return db.executeNonQuery(query);
        }

        public Boolean agregarTarea(Tarea tarea, string idPadre)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos();
            string query = "insert into Tarea (id_tarea, idEncargado) values ('{0}', '{1}')";
            query = string.Format(query, tarea.codigo, tarea.encargado.id);
            return db.executeNonQuery(query);
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
