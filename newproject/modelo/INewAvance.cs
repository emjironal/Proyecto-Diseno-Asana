using Proyecto_Diseno_Asana.modelo;
using Proyecto_Diseno_Asana.oldproject.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.newproject.modelo
{
    interface INewAvance : IAvance
    {
        AvanceMemento Clone();
    }
}
