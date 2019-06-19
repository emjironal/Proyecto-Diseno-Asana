using Proyecto_Diseno_Asana.control.fabrica;
using Proyecto_Diseno_Asana.control.gestor;
using Proyecto_Diseno_Asana.control.reporte;
using Proyecto_Diseno_Asana.controller;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana
{
    class Controlador : control.IController
    {
        static private Controlador instance = new Controlador();
        public DTO dto { get; }

        private Controlador()
        {
            dto = new DTO();
        }

        static public Controlador getInstance()
        {
            return instance;
        }

        public Boolean login()
        {
            GestorUsuario gestorUsuario = new GestorUsuario();
            dto.setUsuario(gestorUsuario.login(dto.getUsuario()));
            return dto.getUsuario() != null;
        }

        public Boolean abrirProyecto()
        {
            GestorProyecto gestorProyecto = new GestorProyecto();
            dto.setProyecto(gestorProyecto.cargarProyecto(dto.getProyecto().id));
            return dto.getProyecto() != null;
        }

        public Boolean importarProyecto(string pathJson)
        {
            GestorProyecto gestorProyecto = new GestorProyecto();
            try
            {
                string json = File.OpenText(pathJson).ReadToEnd();
                Proyecto proyecto = gestorProyecto.importarProyecto(json);
                dto.setProyecto(proyecto);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public Boolean actualizarProyecto(string pathJson)
        {
            GestorProyecto gestorProyecto = new GestorProyecto();
            try
            {
                string json = File.OpenText(pathJson).ReadToEnd();
                Proyecto proyecto = gestorProyecto.actualizarProyecto(json);
                //mergeMiembros;
                //mergeSecciones(agarrar de la posicion countvieja hasta el final);
                //mergeTareasPorSeccion(agarrar de la posicion countvieja hasta el final por cada seccion vieja);
                //mergeSubtareasPorTarea(agarrar de la posicion countvieja hasta el final por cada tarea vieja);
                dto.setProyecto(proyecto);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public Boolean completarUsuario()
        {
            GestorUsuario gestorUsuario = new GestorUsuario();
            return gestorUsuario.completarUsuario(dto.getUsuario());
        }

        public Boolean borrarUsuario()
        {
            return true;
        }

        public bool agregarAvance()
        {
            GestorAvance gestorAvance = new GestorAvance();
            Avance avance = dto.getAvance();
            if (gestorAvance.agregarAvance(avance))
            {
                if((gestorAvance.agregarAvancePorTarea(dto.getTarea().codigo, avance.id.ToString())))
                {
                    dto.getTarea().avances.Add(avance);
                    return true;
                }
            }
            return false;
        }

        public Boolean hacerConsulta(String tipo, object criterio)
        {
            GestorProyecto gestorProyecto = new GestorProyecto();
            dto.avances = gestorProyecto.consultar(tipo, criterio);
            return true;
        }

        public DTO getDTO()
        {
            return this.dto;
        }

        public List<Proyecto> consultarProyectos()
        {
            GestorProyecto gestorProyecto = new GestorProyecto();
            return gestorProyecto.consultarProyectos(dto.getUsuario());
        }

        public List<Tarea> consultarActividades()
        {
            GestorProyecto gestor = new GestorProyecto();
            return gestor.consultarTarea(dto.getProyecto().id);
        }

        public List<Usuario> consultarUsuarios()
        {
            GestorUsuario gestor = new GestorUsuario();
            return gestor.consultarUsuarios();
        }

        public bool generarReportePDF()
        {
            return (new ReportePDF()).generarReporte();
        }

        public bool guardarReportePDF(string path, string filename)
        {
            return (new ReportePDF()).guardarReporte(path + "\\" + filename);
        }
    }
}
