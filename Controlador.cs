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

        private Controlador(){}

        public Controlador getInstance()
        {
            return instance;
        }
    }
}
