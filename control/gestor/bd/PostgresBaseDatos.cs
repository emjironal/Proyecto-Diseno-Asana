using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.control.gestor.bd
{
    class PostgresBaseDatos : GestorBaseDatos
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private NpgsqlConnection conn;

        /// <summary>
        /// PostgresBaseDatos(String Server, String UserId, String  Port, String Password, String DatabaseName): 
        /// <para>parameters pueden ser los componentes del</para>
        /// <para>string de conexión o ser el string ya creado.</para>
        /// <para>parámetros a recibir: </para>
        /// <para>Server: specifies the server location</para>
        /// <para>User Id: the database user</para>
        /// <para>Port: default is 5432</para>
        /// <para>Password: the password for the database user</para>
        /// <para>Database: the database name</para>
        /// </summary>
        public PostgresBaseDatos(params string[] parametros) : base(parametros)  
        {
            String server = parametros[0];
            String userId = parametros[1];
            String port = parametros[2];
            String password = parametros[3];
            String database = parametros[4];
            this.conexion = String.Format("Server={0};" +
                    "User Id={1};Password={2};Database={3};Port={4}",
                    server, userId,
                    password, database,port);
        }

        public override bool conectar()
        {
            this.conn = new NpgsqlConnection(this.conexion);
            conn.Open();
            return true;
        }

        public override object[] consultar(string query, int columns)
        {
            conectar();
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            List<Object> list = new List<object>();
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                List<Object> row = new List<object>();
                for (int i = 0; i < columns; i++)
                    row.Add(dr[i]);
                list.Add(row);
            }
            desconectar();
            return list.ToArray();
        }

        public override bool desconectar()
        {
            conn.Close();
            return true;
        }




    }


    
}
