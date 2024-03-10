using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Facade
{
    public class Facade
    {
        private ISubSystem _subSystem1;
        private ISubSystem _subSystem2;
        private ISubSystem _subSystem3;
        public Facade(ISubSystem subSystem1, ISubSystem subSystem2, ISubSystem subSystem3)
        {
            _subSystem1 = subSystem1;
            _subSystem2 = subSystem2;
            _subSystem3 = subSystem3;
        }
        public string Operation1()
        {
            return $"Facade initializes subsystems:\n{_subSystem1.Operation("Ready")}\n{_subSystem2.Operation("Go")}\n{_subSystem3.Operation("Stop")}";
        }
        public string Operation2()
        {
            return $"Facade orders subsystems to perform the action:\n{_subSystem1.Operation("Start")}\n{_subSystem2.Operation("Run")}\n{_subSystem3.Operation("Halt")}";
        }
    }
}
