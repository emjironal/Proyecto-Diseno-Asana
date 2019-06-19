using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Diseno_Asana.modelo;


namespace Proyecto_Diseno_Asana.newproject.modelo
{
    class Caretaker
    {
        private Stack avances;
        public Caretaker()
        {
            avances = new Stack();
        }
        public MementoI Get()
        {
            return ((MementoI)avances.Pop());
        }
        public void Put(MementoI avance)
        {
            avances.Push(avance);
        }
    }

}
