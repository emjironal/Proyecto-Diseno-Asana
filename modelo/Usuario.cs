using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.modelo
{
    class Usuario
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public bool isAdministrador { get; set; }
        public List<Proyecto> proyectos { get; set; }
        public List<Tarea> tareas { get; set; }
    }
}
