using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettyVizLib.Connect
{
    //the base class for connections
    //I suppose we could have had just this instead of an interface but eh...i'd like to keep this flexible just bc
    //idk if there's something we wanna do in the future where an interface would be convenient for functionality access
    //for something else.
    abstract class Connection : IConnection
    {
        protected ConnectionInfo _info;

        public Connection() { }

        public Connection(string connectionConfigFile)
        {
            //deserialize connection info
        }

        public Connection(string endpoint, string username, string password, string db_name, string port)
        {
            //or just get it all individually
        }

        //this is here in case you want to do some custom logic with the connection after subclassing.
        //maybe you don't need the same things as the ConnectionInfo members and
        //you've made your own custom subclass of ConnectionInfo with what you need
        //you'd do the custom logic here.
        public Connection(Object connInfoObject)
        {

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
