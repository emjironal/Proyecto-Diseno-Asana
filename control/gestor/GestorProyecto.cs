using Proyecto_Diseno_Asana.control.fabrica;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.gestor
{
    class GestorProyecto
    {
        public Proyecto importarProyecto(String json)
        {
            Fabrica fabrica = new FabricaImportacionProyecto();
            Proyecto proyecto = (Proyecto)fabrica.fabricaProducto(json);
            if ((new dao.DAOProyecto()).agregarProyecto(proyecto))
                return proyecto;
            return null;
        }

        public Proyecto actualizarProyecto(String json)
        {
            Proyecto proyecto = importarProyecto(json);
            return proyecto;
        }

        public Proyecto cargarProyecto(String idProyecto)
        {
            return null;
        }

        public Boolean consultar(String tipo, Object criterio)
        {
            return true;
        }

        public List<Proyecto> consultarProyectos()
        {
            return null;
        }
    }
}
