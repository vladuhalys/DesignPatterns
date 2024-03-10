using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Decorator.ConDecorator
{
    public class EmailDecorator : BaseDecorator
    {
        public EmailDecorator(IComponent component) : base(component)
        {
        }
        public override string Send(string message)
        {
            return base.Send(message) + " by Email";
        }
    }

}
