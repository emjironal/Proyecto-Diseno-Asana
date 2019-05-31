using Proyecto_Diseno_Asana.control.dao;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.gestor
{
    class GestorUsuario
    {
        public Boolean crearUsuario(Usuario usr)
        {
            return true;
        }

        public Boolean eliminarUsuario(String correo)
        {
            return true;
        }

        public Boolean completarUsuario(Usuario usr)
        {
            return DAOUsuario.completarUsuario(usr);
        }

        public Boolean login(Usuario usr)
        {
            return true;
        }
    }
}
