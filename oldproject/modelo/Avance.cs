using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Avance
    {
        public string id { get; set; }
        public DateTime Fecha { get; set; }
        public int HorasDedicadas { get; set; }
        public String descripción { get; set; }
        public List<Evidencia> evidencias { get; set; } = new List<Evidencia>();
        public Usuario creador { get; set; }

        public String nbrActividad { get; set; }

        public int cantidadEvidencias { get; set; }
        public override string ToString()
        {
            string str = "";
            str += "ID: " + id + "\n" +
                "Fecha: " + Fecha.ToString("dd/MM/yyy") + "\n" +
                "Horas dedicadas: " + HorasDedicadas.ToString() + "\n" +
                "Descripción: " + descripción + "\n" +
                "Creador: " + creador.nombre + "\n" +
                "Actividad: " + nbrActividad + "\n" +
                "Cantidad de evidencias: " + cantidadEvidencias + "\n";
            return str;
        }
    }
}
