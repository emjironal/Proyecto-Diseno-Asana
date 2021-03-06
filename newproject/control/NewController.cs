﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Diseno_Asana.control.gestor;
using Proyecto_Diseno_Asana.controller;
using Proyecto_Diseno_Asana.modelo;
using Proyecto_Diseno_Asana.newproject.modelo;

namespace Proyecto_Diseno_Asana.newproject.control
{
    class NewController : INewController
    {
        private static NewController instance = new NewController();
        private Controlador controlador;
        public DTO dto { get; }
        private GestorCaretaker gestorCaretaker;
        private NewController()
        {
            controlador = Controlador.getInstance();
            dto = controlador.dto;
            gestorCaretaker = new GestorCaretaker();
        }

        public bool abrirProyecto()
        {
            return controlador.abrirProyecto();
        }

        public bool actualizarProyecto(string pathJson)
        {
            return controlador.actualizarProyecto(pathJson);
        }

        public bool agregarAvance()
        {
            gestorCaretaker.SaveMemento(controlador.dto.getAvance());
            return controlador.agregarAvance();
        }

        public bool borrarUsuario()
        {
            return controlador.borrarUsuario();
        }

        public bool completarUsuario()
        {
            return controlador.completarUsuario();
        }

        public List<Tarea> consultarActividades()
        {
            return controlador.consultarActividades();
        }

        public List<Proyecto> consultarProyectos()
        {
            return controlador.consultarProyectos();
        }

        public List<Usuario> consultarUsuarios()
        {
            return controlador.consultarUsuarios();
        }

        public bool generarReportePDF()
        {
            return controlador.generarReportePDF();
        }

        public bool guardarReportePDF(string path, string filename)
        {
            return controlador.guardarReportePDF(path, filename);
        }

        public bool hacerConsulta(string tipo, object criterio)
        {
            return controlador.hacerConsulta(tipo, criterio);
        }

        public bool importarProyecto(string pathJson)
        {
            return controlador.importarProyecto(pathJson);
        }

        public bool login()
        {
            return controlador.login();
        }

        public bool undoAvance()
        {
            GestorAvance gestorAvance = new GestorAvance();
            string id = gestorCaretaker.UndoMemento();

            return gestorAvance.eliminarAvance(id);
        }

        public static NewController getInstance()
        {
            return instance;
        }

        public DTO getDTO()
        {
            return dto;
        }
    }
}
