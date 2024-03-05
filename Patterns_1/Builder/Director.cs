using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.Builder
{
    public class Director
    {
        private IBuilder<string> _builder;
        public Director(IBuilder<string> builder)
        {
            _builder = builder;
        }
        public void BuildWoodMinimalHouse()
        {
            _builder.BuildWall();
            _builder.BuildDoor();
            _builder.BuildRoof();
        }
        public void BuildWoodHouse()
        {
            _builder.BuildWall();
            _builder.BuildDoor();
            _builder.BuildWindow();
            _builder.BuildRoof();
            _builder.BuildGarden();
        }
        public void BuildMetalHouse()
        {
            _builder.BuildWall();
            _builder.BuildDoor();
            _builder.BuildWindow();
            _builder.BuildRoof();
            _builder.BuildGarage();
        }
        public void DestroyWoodHouse()
        {
            _builder.DestroyWall();
            _builder.DestroyDoor();
            _builder.DestroyWindow();
            _builder.DestroyRoof();
            _builder.DestroyGarden();
        }

        public void DestroyWoodMinimalHouse()
        {
            _builder.DestroyWall();
            _builder.DestroyDoor();
            _builder.DestroyRoof();
        }
        public void DestroyMetalHouse()
        {
            _builder.DestroyWall();
            _builder.DestroyDoor();
            _builder.DestroyWindow();
            _builder.DestroyRoof();
            _builder.DestroyGarage();
        }
    }
}
