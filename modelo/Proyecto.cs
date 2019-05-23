using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Proyecto : ProductoAbstracto
    {
        private String Id { get; set; }
        public String Nombre { get; set; }
        private Usuario AdministradorProyecto { get; set; }
        private List<Usuario> miembros { get; set; }
    }
}
