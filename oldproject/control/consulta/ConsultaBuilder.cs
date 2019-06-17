using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.consulta
{
    interface ConsultaBuilder
    {
        Consulta hacerConsulta(Object criterio);
    }
}
