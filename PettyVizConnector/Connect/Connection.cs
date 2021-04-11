using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettyVizConnector.Connect
{
    //the base class for connections
    //I suppose we could have had just this instead of an interface but eh...i'd like to keep this flexible just bc
    //idk if there's something we wanna do in the future where an interface would be convenient for functionality access
    //for something else.
    abstract class Connection : IConnection
    {
        //for deserializing connection info or just keeping track of it.
        protected struct ConnectionInfo
        {
            public string endpoint; //or it can be a filename...the rest will be optional if it's just a filename
            public string username;
            public string password;
            public string db_name;
        }
        protected ConnectionInfo _info;

        public Connection() { }

        public Connection(string connectionConfigFile)
        {
            //deserialize connection info
        }

        public Connection(string endpoint, string username, string passowrd, string db_name)
        {
            //or just get it all individually
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
