using System;
using System.Text.Json;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PettyVizLib.Connect.Connections
{
    //connection for when we're connecting to a database
    class DBConnection : Connection
    {

        public DBConnection() { }

        public DBConnection(string connectionConfigFile)
        {
            //deserialize connection info
            //need error handling
            _info = JsonSerializer.Deserialize<ConnectionInfo>(File.ReadAllText(connectionConfigFile));
        }

        public DBConnection(string endpoint, string username, string password, string db_name, string port)
        {
            //or just get it all individually
            _info.endpoint = endpoint;
            _info.username = username;
            _info.password = password;
            _info.db_name = db_name;
            _info.port = port;
        }
    }
}
