using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.controller
{
    class DTO
    {
        private Usuario usuario;
        private Proyecto proyecto;
        private Tarea tarea;
        private Avance avance;
        
        public Usuario getUsuario()
        {
            return usuario;
        }

        public Proyecto getProyecto()
        {
            return proyecto;
        }

        public Tarea getTarea()
        {
            return tarea;
        }

        public Avance getAvance()
        {
            return avance;
        }

        public void setUsuario(Usuario usr)
        {
            usuario = usr;
        }

        public void setProyecto(Proyecto pr)
        {
            proyecto = pr;
        }

        public void setTarea(Tarea tarea)
        {
            this.tarea = tarea;
        }

        public void setAvance(Avance avance)
        {
            this.avance = avance;
        }
    }
}
