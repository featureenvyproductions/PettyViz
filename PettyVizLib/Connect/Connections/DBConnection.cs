using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettyVizLib.Connect.Connections
{
    //connection for when we're connecting to a database
    class DBConnection : Connection
    {

        public DBConnection() { }

        public DBConnection(string connectionConfigFile)
        {
            //deserialize connection info
        }

        public DBConnection(string endpoint, string username, string password, string db_name)
        {
            //or just get it all individually
            _info.endpoint = endpoint;
            _info.username = username;
            _info.password = password;
            _info.db_name = db_name;
        }

        public void Close()
        {
            //close the connection
        }

        public void Connect()
        {
            //create our own connection string
        }

        public void Connect(string connectionString)
        {
            //connect using the available connection string.
        }

        public void Execute(string query)
        {
            //execute the query
            //i.e. like an insert or modify query
        }

        public void Execute(string query, out Object data)
        {
            //execute the query and return data from it
            //i.e. like a select query
            data = null;
        }
    }
}
