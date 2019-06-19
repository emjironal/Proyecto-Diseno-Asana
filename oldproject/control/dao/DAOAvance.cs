using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.dao
{
    static class DAOAvance
    {
        public static Boolean crearAvance(Avance avance)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into Avance values ('{0}', '{1}', '{2}', '{3}', '{4}')";
            query = string.Format(query, avance.id, avance.Fecha.ToString("yyyy-MM-dd"), avance.HorasDedicadas, avance.descripción, avance.creador.id);
            bool result = db.executeNonQuery(query);
            foreach(Evidencia evidencia in avance.evidencias)
            {
                result &= agregarEvidencia(evidencia, avance.id);
            }
            db.desconectar();
            return result;
        }

        public static bool agregarAvancePorTarea(string idTarea, string idAvance)
        {
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "insert into AvancePorTarea values ({0}, {1})";
            query = string.Format(query, idTarea, idAvance);
            bool result = db.executeNonQuery(query);
            db.desconectar();
            return result;
        }

        public static Boolean eliminarAvance(string id)
        {

            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            string query = "Delete from EvidenciaPorAvance where id_avance = {0}";
            query = string.Format(query, id);
            bool result = db.executeNonQuery(query);
            query = "Delete from AvancePorTarea where id_avance = {0}";
            query = string.Format(query, id);
            bool result2 = db.executeNonQuery(query);
            query = "Delete from Avance where id_avance = {0}";
            query = string.Format(query, id);
            bool result3 = db.executeNonQuery(query);
            db.desconectar();


            return result && result2 && result3;
        }

        public static bool agregarEvidencia(Evidencia evidencia, string idAvance)
        {
            gestor.bd.PostgresBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            //Query
            Npgsql.NpgsqlCommand objCom = new Npgsql.NpgsqlCommand("insert into EvidenciaPorAvance " + " (id_avance, tipo, documento) values (:id, :tipo, :doc)", db.conn);
            //Id avance
            Npgsql.NpgsqlParameter idAvanceParam = new Npgsql.NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Numeric);
            idAvanceParam.Value = decimal.Parse(idAvance);
            objCom.Parameters.Add(idAvanceParam);
            //Tipo de documento
            Npgsql.NpgsqlParameter tipoParam = new Npgsql.NpgsqlParameter("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar);
            tipoParam.Value = evidencia.tipo;
            objCom.Parameters.Add(tipoParam);
            //Documento
            Npgsql.NpgsqlParameter docParam = new Npgsql.NpgsqlParameter("@doc", NpgsqlTypes.NpgsqlDbType.Bytea);
            docParam.Value = evidencia.documento;
            objCom.Parameters.Add(docParam);
            bool result = objCom.ExecuteNonQuery() != 0;
            db.desconectar();
            return result;
        }
    }
}
