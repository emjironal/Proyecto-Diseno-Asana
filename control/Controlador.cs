using Proyecto_Diseno_Asana.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana
{
    class Controlador
    {
        private Controlador instance;
        private DTO dto;

        private Controlador()
        {
            dto = new DTO();
        }

        public Controlador getInstance()
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

        public Boolean importarProyecto()
        {
            return true;
        }

        public Boolean actualizarProyecto()
        {
            return true;
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

        }

        public Boolean hacerConsulta(String tipo)
        {
            return true;
        }
    }
}
