using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Decorator
{
    public abstract class BaseDecorator : IComponent
    {
        private IComponent _component;
        public BaseDecorator(IComponent component)
        {
            _component = component;
        }
        public virtual string Send(string message)
        {
            return _component.Send(message);
        }
    } 
}
