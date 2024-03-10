using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Facade
{
    public interface ISubSystem
    {
        string Operation(string action);
    }

    public class SubSystem1 : ISubSystem
    {
        public string Operation(string action)
        {
            return $"SubSystem1: {action}";
        }
    }

    public class SubSystem2 : ISubSystem
    {
        public string Operation(string action)
        {
            return $"SubSystem2: {action}";
        }
    }

    public class SubSystem3 : ISubSystem
    {
        public string Operation(string action)
        {
            return $"SubSystem3: {action}";
        }
    }
}
