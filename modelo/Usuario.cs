using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Usuario
    {
        private string Nombre { get; set; }
        private string Correo { get; set; }
        private string Contraseña { get; set; }
        public bool isAdministrador { get; set; }
    }
}
