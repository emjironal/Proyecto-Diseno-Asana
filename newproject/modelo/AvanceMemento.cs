using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class AvanceMemento
    {
        public string id { get; }
        public DateTime Fecha { get; }
        public int HorasDedicadas { get; }
        public String descripción { get; }
        public List<Evidencia> evidencias { get; }
        public Usuario creador { get; }
        public String nbrActividad { get; }
        public int cantidadEvidencias { get; }
        public AvanceMemento(string id, DateTime Fecha, int HorasDedicadas, string descripción, List<Evidencia> evidencias, Usuario creador, string nbrActividad, int cantidadEvidencias)
        {
            this.id = id;
            this.Fecha = Fecha;
            this.HorasDedicadas = HorasDedicadas;
            this.descripción = descripción;
            this.evidencias = evidencias;
            this.creador = creador;
            this.nbrActividad = nbrActividad;
            this.cantidadEvidencias = cantidadEvidencias;
        }
    }
}
