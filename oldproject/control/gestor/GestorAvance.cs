using Proyecto_Diseno_Asana.control.dao;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.gestor
{
    class GestorAvance
    {
        public Boolean agregarAvance(Avance avance)
        {
            DAOAvance.crearAvance(avance);
            return true;
        }

        public Boolean agregarAvancePorTarea(string idTarea, string idAvance)
        {
            return DAOAvance.agregarAvancePorTarea(idTarea, idAvance);
        }

        public Boolean eliminarAvance(string id)
        {
            return (DAOAvance.eliminarAvance(id));
        }
    }
}
