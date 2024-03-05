using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.Builder
{
    public class ClientCode
    {
        public void Main()
        {
            var woodHouseBuilder = new WoodHouseBuilder();
            var director = new Director(woodHouseBuilder);
            Console.WriteLine("App: Launched with the WoodHouseBuilder.");
            director.BuildWoodHouse();
            Console.WriteLine("");
            Console.WriteLine("App: Destroying the WoodHouse.");
            director.DestroyWoodHouse();

            var metalHouseBuilder = new MetalHouseBuilder();
            director = new Director(metalHouseBuilder);
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the MetalHouseBuilder.");
            director.BuildMetalHouse();
            Console.WriteLine("");
            Console.WriteLine("App: Destroying the MetalHouse.");
            director.DestroyMetalHouse();

            var woodMinimalHouseBuilder = new WoodHouseBuilder();
            director = new Director(woodMinimalHouseBuilder);
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the WoodMinimalHouseBuilder.");
            director.BuildWoodMinimalHouse();
            Console.WriteLine("");
            Console.WriteLine("App: Destroying the MetalHouse.");
            director.DestroyWoodMinimalHouse();
        }
    }
}
