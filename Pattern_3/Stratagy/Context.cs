using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Stratagy
{
    public class VirtualMashine
    {
        public Strategy ServerStrategy { get; set; }
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public VirtualMashine(Strategy serverStrategy, string server, string user, string password)
        {
            ServerStrategy = serverStrategy;
            Server = server;
            User = user;
            Password = password;
        }

        public bool IsServerRunning()
        {
           return ServerStrategy.IsServerRunning(Server);
        }

        public string RunServer()
        {
            return ServerStrategy.RunServer(Server, User, Password);
        }

        public string ShutDownServer()
        {
            return ServerStrategy.ShutDownServer(Server, User, Password);
        }
    }
}
