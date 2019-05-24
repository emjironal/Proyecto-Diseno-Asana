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
            string json = (string)entrada;
            var data = JArray.Parse(json);
            Proyecto proyecto = new Proyecto();
            proyecto.secciones = new List<Tarea>();
            Tarea defaultSection = new Tarea();
            proyecto.secciones.Add(defaultSection);
            int seccion = 0;
            foreach (JObject jObject in data)
            {
                Tarea tarea = new Tarea();
                parseCodigo(jObject, tarea);
                parseEncargado(jObject, tarea);
                parseFchFinalizacion(jObject, tarea);
                parseFchEntrega(jObject, tarea);
                parseSeguidores(jObject, tarea);
            }
            return proyecto;
        }

        /**
         * Obtiene los seguidores
         */
        private void parseSeguidores(JObject jObject, Tarea tarea)
        {
            var followers = (JArray)getObjectgFromJObject(jObject, "followers");
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
                tarea.fchEntrega = (DateTime)fchEntrega;
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
            tarea.encargado = parseUsuario(assignee);
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
