using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Stratagy
{
    public class ClientCode
    {
        public void Main()
        {
            Dictionary<string, VirtualMashine> vms = new Dictionary<string, VirtualMashine>
            {
                { "Linux", new VirtualMashine(new LinuxServerStraragy(), "Linux Server 1", "root", "qwerty1111") },
                { "Windows", new VirtualMashine(new WindowsServerStraragy(), "Windows Server 1", "Administrator","admin228") },
                { "MacOS", new VirtualMashine(new MacOSServerStraragy(), "MacOS Server 1", "Apple User", "appleCool") }
            };

            Console.WriteLine(vms["Linux"].RunServer());
            Console.WriteLine(vms["Windows"].RunServer());
            Console.WriteLine(vms["MacOS"].RunServer());

            Console.WriteLine(vms["Linux"].IsServerRunning());
            Console.WriteLine(vms["Windows"].IsServerRunning());
            Console.WriteLine(vms["MacOS"].IsServerRunning());

            Console.WriteLine(vms["Linux"].ShutDownServer());
            Console.WriteLine(vms["Windows"].ShutDownServer());
            Console.WriteLine(vms["MacOS"].ShutDownServer());

            Console.WriteLine(vms["Linux"].IsServerRunning());
            Console.WriteLine(vms["Windows"].IsServerRunning());
            Console.WriteLine(vms["MacOS"].IsServerRunning());
        }
    }
}
