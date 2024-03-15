using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Momento
{
    public class ClientCode
    {
        public void Main()
        {
            Watter watter = new Watter(20, 100, "Liquid");
            Console.WriteLine(watter);
            Console.WriteLine();
            History history = new History();
            history.AddState(new WatterMomento(watter));
            Console.WriteLine();
            watter.SetState(30, 200, "Solid");
            Console.WriteLine(watter);
            Console.WriteLine();
            history.AddState(new WatterMomento(watter));
            watter.SetState(40, 300, "Gas");
            Console.WriteLine(watter);
            Console.WriteLine();
            watter.RestoreState((WatterMomento)history.GetState());
            Console.WriteLine(watter);
            Console.WriteLine();
            watter.RestoreState((WatterMomento)history.GetState());
            Console.WriteLine(watter);
            Console.WriteLine();
        }
    }
}
