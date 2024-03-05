using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.FabricMethod
{
    public class ClientCode
    {

        public void Main()
        {
            var river = new River();
            Console.WriteLine("App: Launched with the RiverTortule.");
            ClientMethod(river);

            var sea = new Sea();
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the SeaTortule.");
            ClientMethod(sea);
        }
        public void ClientMethod(Creator creator)
        {
            Console.WriteLine(creator.EatOperation());
            Console.WriteLine(creator.SleepOperation());
            Console.WriteLine(creator.SwimOperation());
        }
    }
}
