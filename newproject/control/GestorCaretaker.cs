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
        public void SaveMemento(Avance avance)
        {
            NewAvance a = new NewAvance(avance);
            caretaker.Put(a.SaveMemento());
        }
        public string UndoMemento()
        {
            string id = caretaker.Get();
            Proyecto p = NewController.getInstance().getDTO().getProyecto();

            foreach (Tarea t in p.secciones)
            {
                foreach (Tarea t2 in t.tareas)
                {

                    foreach (Avance a in t2.avances)
                    {
                        if (a.id == id)
                        {
                            t2.avances.Remove(a);
                            return id;
                        }
                    }
                    foreach (Tarea t3 in t2.tareas)
                    {

                        foreach (Avance a2 in t3.avances)
                        {
                            if (a2.id == id)
                            {
                                t3.avances.Remove(a2);
                                return id;
                            }

                        }
                    }
                }
            }
            return id;
        }
    }
}
