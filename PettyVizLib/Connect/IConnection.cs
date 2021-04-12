using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettyVizLib.Connect
{
    public interface IConnection
    {
        void Close();
        void Connect();
        void Connect(string connectionString);
        void Execute(string query);
        void Execute(string query, out Object data);
    }
}
