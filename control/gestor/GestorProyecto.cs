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

        public List<Usuario> mergeMiembros(Proyecto oldProyecto, Proyecto newProyecto)
        {
            if (oldProyecto.id == newProyecto.id)
            {
                oldProyecto.miembros = newProyecto.miembros;
            }
            return oldProyecto.miembros;
        }

        public List<Tarea> MergeSecciones(Proyecto oldProyecto, Proyecto newProyecto)
        {
            if (oldProyecto.id == newProyecto.id)
            {
                foreach (Tarea seccion in newProyecto.secciones)
                {
                    for (int i = 0; i < oldProyecto.secciones.Count(); i++)
                    {
                        Tarea oldSeccion = oldProyecto.secciones.ElementAt(i);
                        if (seccion.codigo == oldProyecto.secciones.ElementAt(i).codigo) {
                            actualizarTarea(oldSeccion, seccion);
                        }
                    }
                }
            }
            return null;
        }

        private void actualizarTarea(Tarea oldSeccion, Tarea newSeccion)
        {
            /*
             * isFinalizada
             * fchFinalizacion
             * fchEntrega
             * notas
             * seguidores
             * ecanrgado
             *
             */
        }

        public Tarea mergeSubtarea(Tarea tarea, Tarea tarea1)
        {
            return tarea1;
        }


    }
}
