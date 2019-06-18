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
        public GUIMainAdministrador vista { get; }

        public ProxyVistaMain()
        {
            vista = new GUIMainAdministrador();
            filtrar();
        }

        public void filtrar()
        {
            if (!Controlador.getInstance().getDTO().getUsuario().isAdministrador)
            {
                vista.filtrar();
            }
        }
    }
}
