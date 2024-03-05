using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.Singleton
{
    public class ClientCode
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with");
            var singleton = Singleton.GetInstance();
            singleton.SomeBusinessLogic();

            var singleton2 = Singleton.GetInstance();
            singleton2.SomeBusinessLogic();

            if (singleton == singleton2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
