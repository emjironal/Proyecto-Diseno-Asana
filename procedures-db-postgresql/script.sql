select * from avance;
select * from avanceportarea;
select * from evidenciaporavance;
select * from miembroporproyecto;
select * from proyecto;
select * from seguidorportarea;
select * from tarea;
select * from tareaporproyecto;
select * from tareaporseccion;
select * from usuario;
select id_avance, 
       tipo, 
       documento is null as data_is_null, 
       octet_length(documento) as data_length 
from evidenciaporavance;

truncate avance cascade;
truncate avanceportarea;
truncate evidenciaporavance;
truncate miembroporproyecto;
truncate proyecto cascade;
truncate seguidorportarea;
truncate tarea cascade;
truncate tareaporproyecto;
truncate tareaporseccion;
truncate usuario cascade;
