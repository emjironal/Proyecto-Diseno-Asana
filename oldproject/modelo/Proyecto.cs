using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Proyecto : ProductoAbstracto
    {
        public String id { get; set; }
        public String nombre { get; set; }
        public Usuario administradorProyecto { get; set; }
        public List<Usuario> miembros { get; set; } = new List<Usuario>();
        public List<Tarea> secciones { get; set; } = new List<Tarea>();

        string ProductoAbstracto.getId()
        {
            return this.id;
        }

        object ProductoAbstracto.getNombre()
        {
            return this.nombre;
        }

    }
}
