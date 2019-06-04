select u.id_usuario as "Id creador", u.nombre as "Nombre creador", a.id_avance as "Id avance", a.fecha as "Fecha avance", a.horasDedicadas as "Horas dedicadas", a.descripcion as "Descripcion", count(*) as "Cantidad de evidencia"
from Proyecto p
	inner join MiembroPorProyecto mp on (mp.id_proyecto = p.id_proyecto)
	inner join Usuario u on (u.id_usuario = mp.id_usuario)
	inner join TareaPorProyecto tp on (tp.id_proyecto = p.id_proyecto)
	inner join Tarea t on (t.id_tarea = tp.id_tarea)
	inner join SeguidorPorTarea st on (st.id_usuario = u.id_usuario and st.id_tarea = t.id_tarea)
	inner join AvancePorTarea at on (at.id_tarea = t.id_tarea)
	inner join Avance a on (a.id_avance = at.id_avance and a.creador = u.id_usuario)
	inner join EvidenciaPorAvance ea on (ea.id_avance = a.id_avance)
where p.id_proyecto = '1123693986642643'
	and u.id_usuario = '1116187574009349'
group by "Id creador", "Nombre creador", "Id avance","Fecha avance", "Horas dedicadas", Descripcion