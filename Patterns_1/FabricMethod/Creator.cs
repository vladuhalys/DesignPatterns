using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.FabricMethod
{
    public abstract class Creator
    {

        public abstract Tortule FactoryMethod();

        public string EatOperation()
        {
            var product = FactoryMethod();
            string result = "Creator: The same creator's code has just worked with " + product.Eat();
            return result;
        }

        public string SleepOperation()
        {
            var product = FactoryMethod();
            string result = "Creator: The same creator's code has just worked with " + product.Sleep();
            return result;
        }

        public string SwimOperation()
        {
            var product = FactoryMethod();
            string result = "Creator: The same creator's code has just worked with " + product.Swim();
            return result;
        }
    }

    public class River : Creator
    {
        public override Tortule FactoryMethod()
        {
            return new RiverTortule();
        }
    }

    public class Sea : Creator
    {
        public override Tortule FactoryMethod()
        {
            return new SeaTortule();
        }
    }
}
