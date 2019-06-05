using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.consulta
{
    class ConsultaxActividad : ConsultaBuilder
    {
        public Consulta hacerConsulta(Object criterio)
        {
            String nombreActividad = (string)((object[])criterio)[3];
            Consulta consulta = new Consulta();

            consulta.Select("p.nombre as \"Nombre proyecto\", t.nombre as \"Nombre tarea\"," +
                " u.nombre as \"Nombre seguidor\", av.id_avance as \"Id avance\", av.fecha as \"Fecha avance\", " +
                "av.horasDedicadas as \"Horas dedicadas\", av.descripcion as Descripcion, count(*) as Evidencia");

            consulta.From("AvancePorTarea a");

            consulta.Join("Tarea t", "a.id_tarea = t.id_tarea");
            consulta.Join("TareaPorProyecto tp", "t.id_tarea = tp.id_tarea");
            consulta.Join("Proyecto p", "p.id_proyecto = tp.id_proyecto");
            consulta.Join("Avance av","a.id_avance = av.id_avance");
            consulta.Join("EvidenciaPorAvance e", "av.id_avance = e.id_avance");
            consulta.Join("Usuario u", "u.id_usuario = av.creador");

            consulta.Where("t.nombre = '" + nombreActividad + "'");
            consulta.GroupBy("1,2,3,4,5,6,7");

            return consulta;
        }
    }
}
