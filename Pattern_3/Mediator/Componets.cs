using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Mediator
{
    public interface IComponent
    {
        string Name { get; }
        void ReactOn(object args);
    }

    public class BaseComponent : IComponent
    {
        public string Name { get; }
        public BaseComponent(string name)
        {
            this.Name = name;
        }
        public virtual void ReactOn(object args)
        {
            Console.WriteLine($"Component {this.Name} reacts on {args}.");
        }
    }
    public class ComponentSushiStore : BaseComponent
    {
        public ComponentSushiStore(string name) : base(name)
        {}

        public void MakeSushi()
        {
            Console.WriteLine($"Component {this.Name} makes sushi.");
        }
        public override void ReactOn(object args)
        {
            base.ReactOn(args);
            MakeSushi();
        }
    }
    public class ComponentPizzaResto : BaseComponent
    {
        public ComponentPizzaResto(string name) : base(name)
        { }
        public void MakePizza()
        {
            Console.WriteLine($"Component {this.Name} makes pizza.");
        }
        public override void ReactOn(object args)
        {
            base.ReactOn(args);
            MakePizza();
        }
    }

    public class ComponentBurgerResto : BaseComponent
    {
        public ComponentBurgerResto(string name) : base(name)
        { }
        public void MakeBurger()
        {
            Console.WriteLine($"Component {this.Name} makes burger with french frise and a cup of Coca-Cola.");
        }
        public override void ReactOn(object args)
        {
            base.ReactOn(args);
            MakeBurger();
        }

    }

}
