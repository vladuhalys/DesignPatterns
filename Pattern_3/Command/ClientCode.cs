using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Command
{
    public class ClientCode
    {
        public void Main()
        {
            var helloCommand = new HelloCommands();
            var sumCommand = new SumCommands();
            Console.WriteLine(helloCommand.Execute("John"));
            Console.WriteLine(sumCommand.Execute("1+2+3+4+5"));
        }
    }
}
