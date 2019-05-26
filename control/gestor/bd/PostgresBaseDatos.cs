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
            String userId= parametros[1];
            String password = parametros[2];
            String database = parametros[3];
            this.conexion = String.Format("Server={0};" +
                    "User Id={1};Password={2};Database={3};",
                    server, userId,
                    password, database);
        }

        public override bool conectar()
        {
            this.conn = new NpgsqlConnection(this.conexion);
            conn.Open();
            return true;
        }

        /*
         * https://www.codeproject.com/Articles/30989/Using-PostgreSQL-in-your-C-NET-application-An-intr
         * 
         string sql = "SELECT * FROM simple_table";
                // data adapter making request from our connection
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                // i always reset DataSet before i do
                // something with it.... i don't know why :-)
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);
                // since it C# DataSet can handle multiple tables, we will select first
                dt = ds.Tables[0];
                // connect grid to DataTable
                dataGridView1.DataSource = dt;
             
             */

        public override bool desconectar()
        {
            conn.Close();
            return true;
        }




    }


    
}
