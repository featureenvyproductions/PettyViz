using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettyVizLib.Connect
{
    //for deserializing connection info or just keeping track of it.
    class ConnectionInfo
    {
        public string endpoint; //or it can be a filename...the rest will be optional if it's just a filename
        public string username;
        public string password;
        public string db_name;
        public string port;
    }
}
