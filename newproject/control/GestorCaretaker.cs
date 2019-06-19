using Proyecto_Diseno_Asana.modelo;
using Proyecto_Diseno_Asana.newproject.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.newproject.control
{
    class GestorCaretaker
    {

        private Caretaker caretaker;

        public GestorCaretaker()
        {
            caretaker = new Caretaker();
        }
        public void SaveMemento(NewAvance avance)
        {
            caretaker.Put(avance.SaveMemento());
        }
        public string UndoMemento()
        {
            return caretaker.Get();
        }
        
    }
}
