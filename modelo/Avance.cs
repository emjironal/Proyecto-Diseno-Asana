using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Avance
    {
        public DateTime Fecha { get; set; }
        public int HorasDedicadas { get; set; }
        public String descripción { get; set; }
        public List<Evidencia> evidencias { get; set; }
        public Usuario creador { get; set; }
    }
}
