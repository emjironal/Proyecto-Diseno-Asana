﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Diseno_Asana.modelo;

namespace Proyecto_Diseno_Asana.control.consulta
{
    class ConsultaxFecha : ConsultaBuilder
    {
        public Consulta hacerConsulta(object criterio)
        {
            object[] criterioList = (object[])criterio;
            string fchInicial = (string)criterioList[1], fchFinal = (string)criterioList[2];
            Consulta consulta = new Consulta();
            consulta = consulta
                .Select("u.id_usuario as \"Id creador\", u.nombre as \"Nombre creador\",t.nombre as \"Actividad\", a.id_avance as \"Id avance\", a.fecha as \"Fecha avance\", a.horasDedicadas as \"Horas dedicadas\", a.descripcion as \"Descripcion\", count(*) as \"Cantidad de evidencia\"")
                .From("Proyecto p" +
                        " inner join MiembroPorProyecto mp on(mp.id_proyecto = p.id_proyecto)" +
                        " inner join Usuario u on(u.id_usuario = mp.id_usuario)" +
                        " inner join TareaPorProyecto tp on(tp.id_proyecto = p.id_proyecto)" +
                        " inner join Tarea t on(t.id_tarea = tp.id_tarea)" +
                        " inner join SeguidorPorTarea st on(st.id_usuario = u.id_usuario and st.id_tarea = t.id_tarea)" +
                        " inner join AvancePorTarea at on(at.id_tarea = t.id_tarea)" +
                        " inner join Avance a on(a.id_avance = at.id_avance and a.creador = u.id_usuario)" +
                        " inner join EvidenciaPorAvance ea on(ea.id_avance = a.id_avance)")
                .Where(string.Format("a.fecha > '{0}' and a.fecha < '{1}'", fchInicial, fchFinal))
                .GroupBy("\"Id creador\", \"Nombre creador\", \"Actividad\",\"Id avance\", \"Fecha avance\", \"Horas dedicadas\", \"Descripcion\"");
            return consulta;
        }
    }
}
