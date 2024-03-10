using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Decorator
{
    public interface IComponent
    {
        string Send(string message);
    }
    public class MobileNotify : IComponent
    {
        public string Name { get; set; }
        public MobileNotify(string name)
        {
            Name = name;
        }
        public string Send(string message)
        {
            return $"Mobile {Name} send \"{message}\"";
        }
    }
    public class WebNotify : IComponent
    {
        public string Name { get; set; }
        public WebNotify(string name)
        {
            Name = name;
        }
        public string Send(string message)
        {
            return $"Website {Name} send \"{message}\"";
        }
    }
    public class ServerNotify : IComponent
    {
        public string Name { get; set; }
        public ServerNotify(string name)
        {
            Name = name;
        }
        public string Send(string message)
        {
            return $"Server {Name} send \"{message}\"";
        }
    }

}
