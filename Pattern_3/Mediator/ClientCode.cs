using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Mediator
{
    public class ClientCode
    {
        public void Main()
        {
            Mediator mediator = new Mediator();
            mediator.AddComponent("sushi", new ComponentSushiStore("Sushi Store"));
            mediator.AddComponent("pizza", new ComponentPizzaResto("Pizza Frederiko"));
            mediator.AddComponent("burger", new ComponentBurgerResto("Burger King"));
            string sender = "sushi";
            mediator.Notify(sender);
            mediator.RemoveComponent("pizza");
            sender = "pizza";
            mediator.Notify(sender);
        }
    }
}
