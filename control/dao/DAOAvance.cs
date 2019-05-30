using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.dao
{
    class DAOAvance
    {
        public Boolean crearAvance(Avance avance)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into Avance values ({0}, {1}, {2}, {3}, {4})";
            query = string.Format(query, avance.id, avance.Fecha.ToString("yyyy-mm-dd"), avance.HorasDedicadas, avance.descripción, avance.creador.id);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public bool agregarAvancePorTarea(string idTarea, string idAvance)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into AvancePorTarea values ({0}, {1})";
            query = string.Format(query, idTarea, idAvance);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public Boolean eliminarAvance(int id)
        {
            return true;
        }
    }
}
