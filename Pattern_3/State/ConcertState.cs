using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.State
{
    public class StateLessWidget<T> : State<T>
    {
        protected T _value;
        public override void Build()
        {

            Console.WriteLine($"Widget is built with {_value}");
        }
        public override void Dispose()
        {
            Console.WriteLine("Widget is disposed.");
        }
        public override void InitState(T value)
        {
            _value = value;
            Console.WriteLine($"Widget is initialized with value {value}.");
        }
        public override void SetState(T value)
        {
            Console.WriteLine($"Widget can`t set value!");
        }
    }

    public class StateFullWidget<T> : State<T>
    {
        protected T _value;
        public override void Build()
        {
            Console.WriteLine($"Widget is built with value {_value}.");
        }
        public override void Dispose()
        {
            Console.WriteLine("Widget is disposed.");
        }
        public override void InitState(T value)
        {
            _value = value;
            Console.WriteLine($"Widget is initialized with value {_value}.");
        }
        public override void SetState(T value)
        {
            _value = value;
            Console.WriteLine($"Widget is set with value {_value}.");
        }
    }
}
