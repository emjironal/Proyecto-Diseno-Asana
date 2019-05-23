using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Tarea
    {
        private String codigo { get; set; }
        private String nombre { get; set; }
        private DateTime fchFinalizacion { get; set; }
        private DateTime fchEntrega { get; set; }
        private String nota { get; set; }
        private List<Tarea> tareas { get; set; }
        private List<Avance> avances { get; set; }
        private List<Usuario> seguidores { get; set; }
        private Usuario encargado { get; set; }
    }
}
