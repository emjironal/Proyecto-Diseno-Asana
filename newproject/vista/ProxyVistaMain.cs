using Proyecto_Diseno_Asana.newproject.control;
using Proyecto_Diseno_Asana.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Diseno_Asana.newproject.vista
{
    class ProxyVistaMain : FiltroVista
    {
        public GUIMain vista { get; }

        public ProxyVistaMain()
        {
            vista = new GUIMain();
            filtrar();
        }

        public void filtrar()
        {
            if (!NewController.getInstance().getDTO().getUsuario().isAdministrador)
            {
                vista.filtrar();
            }
        }
    }
}
