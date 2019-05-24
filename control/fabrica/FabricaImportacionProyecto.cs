using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Diseno_Asana.modelo;
using Newtonsoft.Json.Linq;

namespace Proyecto_Diseno_Asana.control.fabrica
{
    class FabricaImportacionProyecto : Fabrica
    {
        public ProductoAbstracto fabricaProducto(object entrada)
        {
            string jsonstr = (string)entrada;
            JObject json = JObject.Parse(jsonstr);
            JArray data = (JArray)getObjectgFromJObject(json, "data");
            Proyecto proyecto = new Proyecto();
            proyecto.secciones = new List<Tarea>();
            Tarea defaultSection = new Tarea();
            defaultSection.tareas = new List<Tarea>();
            proyecto.secciones.Add(defaultSection);
            foreach (JObject jObject in data)
            {
                Tarea tarea = parseTarea(jObject);
                if((string)getObjectgFromJObject(jObject, "resource_subtype") == "section")
                {
                    proyecto.secciones.Add(tarea);
                }
                else
                {
                    proyecto.secciones.Last<Tarea>().tareas.Add(tarea);
                }
            }
            return proyecto;
        }

        /**
         * Obtiene la tarea
         */
        private Tarea parseTarea(JObject jObject)
        {
            Tarea tarea = new Tarea();
            parseCodigo(jObject, tarea);
            parseEncargado(jObject, tarea);
            parseFchFinalizacion(jObject, tarea);
            parseFchEntrega(jObject, tarea);
            parseSeguidores(jObject, tarea);
            parseNombre(jObject, tarea);
            parseNotas(jObject, tarea);
            parseSubtareas(jObject, tarea);
            return tarea;
        }

        /**
         * Obtiene las subtareas
         */
        private void parseSubtareas(JObject jObject, Tarea tarea)
        {
            JArray subtasks = (JArray)getObjectgFromJObject(jObject, "subtasks");
            tarea.tareas = new List<Tarea>();
            foreach(JObject subtask in subtasks)
            {
                Tarea subtarea = parseTarea(subtask);
                tarea.tareas.Add(subtarea);
            }
        }

        /**
         * Obtiene las notas
         */
        private void parseNotas(JObject jObject, Tarea tarea)
        {
            tarea.notas = (string)getObjectgFromJObject(jObject, "notes");
        }

        /**
         * Obtiene el nombre
         */
        private void parseNombre(JObject jObject, Tarea tarea)
        {
            tarea.nombre = (string)getObjectgFromJObject(jObject, "name");
        }

        /**
         * Obtiene los seguidores
         */
        private void parseSeguidores(JObject jObject, Tarea tarea)
        {
            JArray followers = (JArray)getObjectgFromJObject(jObject, "followers");
            tarea.seguidores = new List<Usuario>();
            foreach (JObject seguidor in followers)
            {
                Usuario usuario = parseUsuario(seguidor);
                tarea.seguidores.Add(usuario);
            }
        }

        /**
         * Obtiene la fecha de entrega
         */
        private void parseFchEntrega(JObject jObject, Tarea tarea)
        {
            var fchEntrega = getObjectgFromJObject(jObject, "due_on");
            if (fchEntrega != null)
            {
                DateTime fch;
                DateTime.TryParseExact((string)fchEntrega, "yyyy-mm-dd", null, System.Globalization.DateTimeStyles.None, out fch);
                tarea.fchEntrega = fch;
            }
        }

        /**
         * Obtiene la fecha de finalización
         */
        private void parseFchFinalizacion(JObject jObject, Tarea tarea)
        {
            tarea.isFinalizada = (bool)getObjectgFromJObject(jObject, "completed");
            if (tarea.isFinalizada)
            {
                tarea.fchFinalizacion = (DateTime)getObjectgFromJObject(jObject, "completed_at");
            }
        }

        /**
         * Obtiene al encargado
         */
        private void parseEncargado(JObject jObject, Tarea tarea)
        {
            JObject assignee = (JObject) getObjectgFromJObject(jObject, "assignee");
            if (assignee != null)
            {
                tarea.encargado = parseUsuario(assignee);
            }
        }

        private Usuario parseUsuario(JObject jObject)
        {
            Usuario usuario = new Usuario();
            usuario.id = (string)getObjectgFromJObject(jObject, "gid");
            usuario.nombre = (string)getObjectgFromJObject(jObject, "name");
            return usuario;
        }

        /**
         * Obtiene el id de la tarea
         */
        private void parseCodigo(JObject jObject, Tarea tarea)
        {
            tarea.codigo = (string)getObjectgFromJObject(jObject, "gid");
        }

        private Object getObjectgFromJObject(JObject jObject, string property)
        {
            return jObject.GetValue(property).ToObject<Object>();
        }
    }
}
