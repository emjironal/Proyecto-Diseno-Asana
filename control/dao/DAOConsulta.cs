using Proyecto_Diseno_Asana.control.consulta;
using Proyecto_Diseno_Asana.control.gestor.bd;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.dao
{
    static class DAOConsulta
    {
        private static ConsultaBuilder builder;

        private static Consulta constructQuery(Object criterio)
        {
            object[] criterioList = (object[])criterio;
            if ((string)criterioList[0] == "miembro")
                builder = new ConsultaxMiembro();
            else if ((string)criterioList[0] == "actividad")
                builder = new ConsultaxActividad();
            else if ((string)criterioList[0] == "fecha")
                builder = new ConsultaxFecha();
            return builder.hacerConsulta(criterio);
        }

        public static List<Avance> executeQuery(Object criterio)
        {
            string query = constructQuery(criterio).Get();
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            object[][] resultSet = db.consultar(query, 8);
            db.desconectar();
            List<Avance> avances = new List<Avance>();
            darFormato(avances, resultSet);
            return avances;
        }

        private static Boolean darFormato(List<Avance> listaAvances, object[][] resultSet)
        {
            foreach(object[] fila in resultSet)
            {
                Avance avance = new Avance();
                //Usuario creador
                avance.creador = new Usuario();
                avance.creador.id = (string)fila[0];
                avance.creador.nombre = (string)fila[1];
                avance.nbrActividad = (string)fila[2];
                //Avance
                avance.id = ((decimal)fila[3]).ToString();
                avance.Fecha = (DateTime)fila[4];
                avance.HorasDedicadas = int.Parse(((decimal)fila[5]).ToString());
                avance.descripción = (string)fila[6];
                avance.cantidadEvidencias = int.Parse(((Int64)fila[7]).ToString());
                listaAvances.Add(avance);
            }
            return true;
        }
    }
}
