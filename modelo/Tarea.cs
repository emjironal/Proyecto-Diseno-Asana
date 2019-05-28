using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Tarea
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public bool isFinalizada { get; set; }
        public DateTime fchFinalizacion { get; set; }
        public DateTime fchEntrega { get; set; }
        public String notas { get; set; }
        public List<Tarea> tareas { get; set; } = new List<Tarea>();
        public List<Avance> avances { get; set; } = new List<Avance>();
        public List<Usuario> seguidores { get; set; } = new List<Usuario>();
        public Usuario encargado { get; set; }
    }
}
 