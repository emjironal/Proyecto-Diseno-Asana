﻿using Proyecto_Diseno_Asana.control.consulta;
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
            string[] criterioList = (string[])criterio;
            if (criterioList[0] == "miembro")
                builder = new ConsultaxMiembro();
            else if (criterioList[0] == "actividad")
                builder = new ConsultaxActividad();
            else if (criterioList[0] == "fecha")
                builder = new ConsultaxFecha();
            return builder.hacerConsulta(criterio);
        }

        public static List<Avance> executeQuery(Object criterio)
        {
            string query = constructQuery(criterio).Get();
            gestor.GestorBaseDatos db = new gestor.bd.PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "asana_upgradedb");
            db.conectar();
            object[][] resultSet = db.consultar(query, 100);
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
                //Avance
                avance.id = ((int)fila[2]).ToString();
                avance.Fecha = DateTime.ParseExact((string)fila[3], "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                avance.HorasDedicadas = (int)fila[4];
                avance.descripción = (string)fila[5];
                listaAvances.Add(avance);
            }
            return true;
        }
    }
}
