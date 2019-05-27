using Proyecto_Diseno_Asana.control.fabrica;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.gestor
{
    class GestorProyecto
    {
        public Proyecto importarProyecto(String json)
        {
            Fabrica fabrica = new FabricaImportacionProyecto();
            Proyecto proyecto = (Proyecto)fabrica.fabricaProducto(json);
            return proyecto;
        }

        public Proyecto actualizarProyecto(String json)
        {
            Proyecto proyecto = importarProyecto(json);
            return proyecto;
        }

        public Proyecto cargarProyecto(String idProyecto)
        {
            return null;
        }

        public Boolean consultar(String tipo, Object criterio)
        {
            return true;
        }

        //Mergin

        public Proyecto mergeMiemrbros(Proyecto proyecto1, Proyecto proyecto2)
        {
            //miembros
            return proyecto1;
        }

        public Tarea mergeTareas(Tarea tarea, Tarea tarea1)
        {
            //
            return tarea1;
        }

        public Tarea mergeSubtarea(Tarea tarea, Tarea tarea1)
        {
            return tarea1;
        }


    }
}
