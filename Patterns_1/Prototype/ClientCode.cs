using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.Prototype
{
    public class ClientCode
    {
        public void Main()
        {
            var testObject = new TestObject("Test", 1);
            Console.WriteLine("App: Launched with the TestObject.");
            ClientMethod(testObject);
            var testObject2 = (TestObject)testObject.Clone();
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the TestObject2.");
            ClientMethod(testObject2);
        }
        public void ClientMethod(TestObject testObject)
        {
            Console.WriteLine(testObject.Name);
            Console.WriteLine(testObject.Age);
        }
    }
}
