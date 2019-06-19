using Proyecto_Diseno_Asana.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.newproject.control
{
    interface INewController : IController
    {
        bool undoAvance();
    }
}
