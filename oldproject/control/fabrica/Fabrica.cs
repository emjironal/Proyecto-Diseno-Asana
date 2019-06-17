using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.fabrica
{
    interface Fabrica
    {
        ProductoAbstracto fabricaProducto(Object entrada);
    }
}
