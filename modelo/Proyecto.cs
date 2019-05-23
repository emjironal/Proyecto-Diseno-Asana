using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Proyecto : ProductoAbstracto
    {
        private String id { get; set; }
        public String nombre { get; set; }
        private Usuario administradorProyecto { get; set; }
        private List<Usuario> miembros { get; set; }
        private List<Tarea> secciones { get; set; }
    }
}
