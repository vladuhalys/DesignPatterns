using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.AbstractFactory
{
    public class ClientCode
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the SamsungFactory.");
            ClientMethod(new SamsungFactory());
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the AppleFactory.");
            ClientMethod(new AppleFactory());
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the XiaomiFactory.");
            ClientMethod(new XiaomiFactory());
        }

        public void ClientMethod(IAbstractFactory abstractFactory)
        {
            var smartphone = abstractFactory.CreateSmartphone();
            var tablet = abstractFactory.CreateTablet();
            Console.WriteLine(smartphone.Call());
            Console.WriteLine(smartphone.Update());
            Console.WriteLine(smartphone.Message());
            Console.WriteLine();
            Console.WriteLine(tablet.Call());
            Console.WriteLine(tablet.Update());
            Console.WriteLine(tablet.Watch());
        }
    }
}
