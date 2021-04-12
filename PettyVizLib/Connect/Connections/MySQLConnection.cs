using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettyVizLib.Connect.Connections
{
    class MySQLConnection : DBConnection
    {
        MySqlConnection _conn;

        public void Close()
        {
            //close the connection
            _conn.Close();
        }

        public void Connect()
        {
            //create our own connection string
            //and connect
            string connStr = "server=" + _info.endpoint + ";user=" + _info.username + ";database=" + _info.db_name + ";port=" + _info.port + ";password=" + _info.password;
            _conn = new MySqlConnection(connStr);
            _conn.Open();
        }

        public void Connect(string connectionString)
        {
            Connect(); //ignore connection string inputs for this class 
        }

        public void Execute(string query)
        {
            //execute the query
            //i.e. like an insert or modify query
            MySqlCommand cmd = new MySqlCommand(query, _conn);
            cmd.ExecuteNonQuery(); //tbd....log rows affected
        }

        public void Execute(string query, out Object data)
        {
            //execute the query and return data from it
            //i.e. like a select query

            MySqlCommand cmd = new MySqlCommand(query, _conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            //tbd....check that rows aren't empty first

            //get the column list
            DataColumnCollection cols = rdr.GetSchemaTable().Columns;
            DataTable dt = new System.Data.DataTable();

            for (int i = 0; i < cols.Count; i++)
            {
                dt.Columns.Add(cols[i]);
            }

            dt.AcceptChanges();
            //read the data
            while (rdr.Read())
            {
                //who knows if this works i'm experimenting for now...
                object[] values = null;
                rdr.GetValues(values);
                dt.Rows.Add(values);
                dt.AcceptChanges();
            }
            rdr.Close();
            data = dt;
        }
    }
}
