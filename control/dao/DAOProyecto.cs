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
        gestor.GestorBaseDatos DbConnection;

        public DAOProyecto() {
            this.DbConnection = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
        }


        public Boolean agregarProyecto(Proyecto proyecto)
        {
            return true;
        }

        public Boolean agregarTarea(Tarea tarea)
        {
            return true;
        }

        public Proyecto consultarProyecto(String id)
        {
            Object[] proyAttrib = DbConnection.consultar(new Consulta().Select("*").From("Proyecto").Where(String.Format("id_proyecto = '{0}'",id)).Get(), 3);
            Proyecto proyecto = new Proyecto();
            try
            {
                proyecto.id = ((String[]) proyAttrib[0])[0];
                //proyecto.administradorProyecto = 
            }
            catch (Exception e) {

            }
            

            return null;
        }

        private List<Tarea> consultarTarea(String proyecto)
        {
            return null;
        }

        private List<Tarea> consultarTareaHijas(int tareaPadre)
        {
            return null;
        }
    }
}
