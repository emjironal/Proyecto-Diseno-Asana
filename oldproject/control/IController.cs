using Proyecto_Diseno_Asana.controller;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control
{
    abstract class IController
    {
        public DTO dto { get; }
        abstract public bool login();
        abstract public bool abrirProyecto();
        abstract public bool importarProyecto(string pathJson);
        abstract public bool actualizarProyecto(string pathJson);
        abstract public bool completarUsuario();
        abstract public bool borrarUsuario();
        abstract public bool agregarAvance();
        abstract public bool hacerConsulta(string tipo, object criterio);
        abstract public List<Proyecto> consultarProyectos();
        abstract public List<Tarea> consultarActividades();
        abstract public List<Usuario> consultarUsuarios();
        abstract public bool generarReportePDF();
        abstract public bool guardarReportePDF(string path, string filename);
    }
}
