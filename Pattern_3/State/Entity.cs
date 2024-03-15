using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.State
{
    public class AppBar : StateLessWidget<string>
    {
        public override void Build()
        {
            Console.WriteLine($"AppBar is built with value {_value}.");
        }
        public override void Dispose()
        {
            Console.WriteLine("AppBar is disposed.");
        }
        public override void InitState(string value)
        {
            _value = value;
            Console.WriteLine($"AppBar is initialized with value {_value}.");
        }
        public override void SetState(string value)
        {
           base.SetState(value);
        }
    }

    public class TextField : StateFullWidget<string>
    {
        public override void Build()
        {
            Console.WriteLine($"TextField is built with value {_value}.");
        }
        public override void Dispose()
        {
            Console.WriteLine("TextField is disposed.");
        }
        public override void InitState(string value)
        {
            _value = value;
            Console.WriteLine($"TextField is initialized with value {_value}.");
        }
        public override void SetState(string value)
        {
            _value = value;
            Console.WriteLine($"TextField is set with value {_value}.");
        }
    }
}
