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
                //Obtiene el id de la tarea
                tarea.codigo = (string)getObjectgFromJObject(jObject, "gid");
                //Obtiene al encargado
                JObject assignee = (JObject)getObjectgFromJObject(jObject, "assignee");
                tarea.encargado = new Usuario();
                tarea.encargado.id = (string)getObjectgFromJObject(assignee, "gid");
                tarea.encargado.nombre = (string)getObjectgFromJObject(assignee, "name");
                //Obtiene la fecha de finalización
                tarea.isFinalizada = (bool)getObjectgFromJObject(jObject, "completed");
                if (tarea.isFinalizada)
                {
                    tarea.fchFinalizacion = (DateTime)getObjectgFromJObject(jObject, "completed_at");
                }
                //Obtiene la fecha de entrega
                var fchEntrega = getObjectgFromJObject(jObject, "due_on");
                if ( fchEntrega != null)
                {
                    tarea.fchEntrega = (DateTime)fchEntrega;
                }
                //Obtiene los seguidores
            }
            return proyecto;
        }

        private Object getObjectgFromJObject(JObject jObject, string property)
        {
            return jObject.GetValue(property).ToObject<Object>();
        }
    }
}
