using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Avance
    {
        private DateTime Fecha { get; set; }
        private int HorasDedicadas { get; set; }
        private String descripción { get; set; }
        private List<Evidencia> evidencias { get; set; }
    }
}
