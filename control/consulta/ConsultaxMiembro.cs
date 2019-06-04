using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Diseno_Asana.modelo;

namespace Proyecto_Diseno_Asana.control.consulta
{
    class ConsultaxMiembro : ConsultaBuilder
    {
        public Consulta hacerConsulta(object criterio)
        {
            object[] criterioList = (object[])criterio;
            string idProyecto = (string)criterioList[1], idUsuario = (string)criterioList[2];
            Consulta consulta = new Consulta();
            consulta = consulta
                .Select("u.id_usuario as \"Id creador\", u.nombre as \"Nombre creador\", a.id_avance as \"Id avance\", a.fecha as \"Fecha avance\", a.horasDedicadas as \"Horas dedicadas\", a.descripcion as \"Descripcion\", count(*) as \"Cantidad de evidencia\"")
                .From("Proyecto p"+
                        " inner join MiembroPorProyecto mp on(mp.id_proyecto = p.id_proyecto)"+
                        " inner join Usuario u on(u.id_usuario = mp.id_usuario)" +
                        " inner join TareaPorProyecto tp on(tp.id_proyecto = p.id_proyecto)" +
                        " inner join Tarea t on(t.id_tarea = tp.id_tarea)" +
                        " inner join SeguidorPorTarea st on(st.id_usuario = u.id_usuario and st.id_tarea = t.id_tarea)" +
                        " inner join AvancePorTarea at on(at.id_tarea = t.id_tarea)" +
                        " inner join Avance a on(a.id_avance = at.id_avance and a.creador = u.id_usuario)" +
                        " inner join EvidenciaPorAvance ea on(ea.id_avance = a.id_avance)")
                .Where(string.Format("p.id_proyecto = '{0}' and u.id_usuario = '{1}'", idProyecto, idUsuario))
                .GroupBy("\"Id creador\", \"Nombre creador\", \"Id avance\", \"Fecha avance\", \"Horas dedicadas\", \"Descripcion\"");
            return consulta;
        }
    }
}
