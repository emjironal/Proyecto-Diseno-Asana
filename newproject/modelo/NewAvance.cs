using Proyecto_Diseno_Asana.modelo;
using Proyecto_Diseno_Asana.oldproject.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.newproject.modelo
{
    class NewAvance: INewAvance
    {
        public Avance avance;

        public NewAvance(Avance a)
        {
            avance = a;
        }
        override public string ToString()
        {
            return (avance.ToString());
        }
        public AvanceMemento SaveMemento()
        {
            AvanceMemento am = new AvanceMemento(avance.id, avance.Fecha, avance.HorasDedicadas, avance.descripción, avance.evidencias, avance.creador, avance.nbrActividad, avance.cantidadEvidencias);
            return am;
        }
    }
}
