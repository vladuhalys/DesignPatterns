using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.FabricMethod
{
    public interface ITortule
    {
        string Swim();
        string Sleep();
        string Eat();
    }

    public abstract class Tortule : ITortule
    {
        public abstract string Eat();
        public abstract string Sleep();
        public abstract string Swim();
    }


    class RiverTortule : Tortule
    {
        public override string Eat()
        {
            return "I eat river fish";
        }

        public override string Sleep()
        {
            return "I sleep in the river";
        }

        public override string Swim()
        {
            return "I swim in the river";
        }
    }

    class SeaTortule : Tortule
    {
        public override string Eat()
        {
            return "I eat sea fish";
        }

        public override string Sleep()
        {
            return "I sleep in the sea";
        }

        public override string Swim()
        {
            return "I swim in the sea";
        }
    }
}
