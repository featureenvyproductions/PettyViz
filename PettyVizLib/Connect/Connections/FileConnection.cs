using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettyVizLib.Connect.Connections
{
    //connection for when we're just loading input from a file
    //like a csv or excel file
    class FileConnection : Connection
    {
        public FileConnection()
        {
        }

        public FileConnection(string connectionConfigFile)
        {
            //deserialize connection info
            //tbd....
        }

        public FileConnection(string endpoint, string username, string passowrd, string db_name)
        {
            //we can really just have the endpoint
            _info.endpoint = endpoint;
            _info.username = null;
            _info.password = null;
            _info.db_name = null;
        }

        //load our contents into a temporary table.
        //or complain if too much
        //or you can call the one with connection string but the string just gets ignored
        public void Connect()
        {
            //load data into a temporary table.
        }
        
        public void Connect(string connectionString)
        {
            Connect(); //for this class we don't need to do anything special
        }

        public void Execute(string query)
        {
        }

        public void Execute(string query, out Object data)
        {
            //execute the query on the data and return data from it
            //i.e. like a select query
            data = null;
        }
    }
}
