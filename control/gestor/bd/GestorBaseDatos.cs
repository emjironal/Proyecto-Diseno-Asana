using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.gestor
{
    abstract class GestorBaseDatos
    {
        protected String conexion;

        public GestorBaseDatos(params String[] parameters)
        {
            String conexion = "";
            this.conexion = conexion;
        }

        public abstract Boolean conectar();

        public abstract Boolean desconectar();

        public abstract Object[] consultar(String query);
    }


}
