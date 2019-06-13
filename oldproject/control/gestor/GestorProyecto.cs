using Proyecto_Diseno_Asana.control.dao;
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
            DAOProyecto.agregarProyecto(proyecto);
            return proyecto;
        }

        public Proyecto actualizarProyecto(String json)
        {
            Proyecto proyecto = importarProyecto(json);
            GestorProyecto p = new GestorProyecto();
            Proyecto oldProyecto = p.cargarProyecto(proyecto.id);
            proyecto.miembros = mergeMiembros(proyecto, oldProyecto);
            proyecto.secciones = MergeSecciones(proyecto, oldProyecto);
            return proyecto;
        }

        public Proyecto cargarProyecto(String idProyecto)
        {
            return DAOProyecto.consultarProyecto(idProyecto);
        }

        public List<Avance> consultar(String tipo, Object criterio)
        {
            object[] criterioList = (object[])criterio;
            criterioList[0] = tipo;
            return DAOConsulta.executeQuery(criterioList);
        }

        public List<Proyecto> consultarProyectos(Usuario usr)
        {
            return DAOProyecto.consultarProyectos(usr);
        }

        public List<Tarea> consultarTarea(string idProyecto)
        {
            return DAOProyecto.consultarActividades(idProyecto);
        }

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
            List<Tarea> result = new List<Tarea>();
            if (oldProyecto.id == newProyecto.id)
            {
                foreach (Tarea seccion in newProyecto.secciones)
                {
                    for (int i = 0; i < oldProyecto.secciones.Count(); i++)
                    {
                        Tarea oldSeccion = oldProyecto.secciones.ElementAt(i);
                        if (seccion.codigo == oldProyecto.secciones.ElementAt(i).codigo) {
                            Tarea nueva = actualizarTarea(oldSeccion, seccion);
                            result.Add(nueva);
                        }
                    }
                }
            }
            return result;
        }

        private Tarea actualizarTarea(Tarea oldSeccion, Tarea newSeccion)
        {
            /*
             * isFinalizada
             * fchFinalizacion
             * fchEntrega
             * notas
             * seguidores
             * encargado
             */
            Tarea updatedTarea = newSeccion;
            if (oldSeccion.codigo == newSeccion.codigo)
            {
                List<Tarea> updatedSubTareas = new List<Tarea>();
                bool isNew = true;
                foreach (Tarea tarea in newSeccion.tareas) {
                    for (int i = 0; i < oldSeccion.tareas.Count; i++) {
                        if (tarea.codigo == oldSeccion.tareas.ElementAt(i).codigo)
                        {
                            Tarea nueva = mergeSubtarea(oldSeccion, newSeccion);
                            updatedSubTareas.Add(nueva);
                            isNew = false;
                            break;
                        }
                    }
                    if (isNew) {
                        updatedSubTareas.Add(tarea);
                        break;
                    } 
                    isNew = true;
                }
                updatedTarea.tareas = updatedSubTareas;
            }
            return updatedTarea;
        }

        public Tarea mergeSubtarea(Tarea oldTarea, Tarea newTarea)
        {
            Tarea result = newTarea;
            result.avances = oldTarea.avances;
            return result;
        }


    }
}