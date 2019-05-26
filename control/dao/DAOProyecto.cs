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
            return true;
        }

        public Boolean agregarTarea(Tarea tarea)
        {
            return true;
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
