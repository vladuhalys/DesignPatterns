using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Command
{
    public class HelloCommands : ICommand<string, string>
    {
        public string Execute(string name)
        {
            return $"Hello, {name}!";
        }
    }

    public class SumCommands : ICommand<int, string>
    {
        public int Execute(string expresion)
        {
            var values = expresion.Split('+');
            int sum = 0;
            foreach(var value in values)
            {
                sum += int.Parse(value);
            }
            return sum;
        }
    }
}
