using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.reporte
{
    interface Reporte
    {
        Boolean generarReporte();
        Boolean guardarReporte(string pathWithNameNoExtension);
    }
}
