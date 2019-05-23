using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Usuario
    {
        private string nombre { get; set; }
        private string correo { get; set; }
        private string contraseña { get; set; }
        private bool isAdministrador { get; set; }
        private List<Proyecto> proyectos { get; set; }
        private List<Tarea> tareas { get; set; }
    }
}
