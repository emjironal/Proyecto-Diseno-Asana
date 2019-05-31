using Proyecto_Diseno_Asana.control.fabrica;
using Proyecto_Diseno_Asana.control.gestor;
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
    class Controlador
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
            return true;
        }

        public void abrirProyecto()
        {

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
            return true;
        }

        public Boolean borrarUsuario()
        {
            return true;
        }

        public void agregarAvance()
        {
            GestorAvance gestorAvance = new GestorAvance();
            Avance avance = dto.getAvance();
            if (gestorAvance.agregarAvance(avance))
            {
                if((gestorAvance.agregarAvancePorTarea(dto.getTarea().codigo, avance.id.ToString())))
                    dto.getTarea().avances.Add(avance);
            }
        }

        public Boolean hacerConsulta(String tipo)
        {
            return true;
        }

        public DTO getDTO()
        {
            return this.dto;
        }

        public List<Proyecto> consultarProyectos()
        {
            GestorProyecto gestorProyecto = new GestorProyecto();
            return gestorProyecto.consultarProyectos();
        }

    }
}
