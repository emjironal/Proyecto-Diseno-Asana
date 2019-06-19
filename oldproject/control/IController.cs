using Proyecto_Diseno_Asana.controller;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control
{
    interface IController
    {
        bool login();
        bool abrirProyecto();
        bool importarProyecto(string pathJson);
        bool actualizarProyecto(string pathJson);
        bool completarUsuario();
        bool borrarUsuario();
        bool agregarAvance();
        bool hacerConsulta(string tipo, object criterio);
        List<Proyecto> consultarProyectos();
        List<Tarea> consultarActividades();
        List<Usuario> consultarUsuarios();
        bool generarReportePDF();
        bool guardarReportePDF(string path, string filename);
    }
}
