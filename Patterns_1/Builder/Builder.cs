using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.Builder
{
    public interface IBuilder<T>
    {
        T BuildWall();

        T BuildDoor();

        T BuildWindow();

        T BuildRoof();

        T BuildGarage();

        T BuildGarden();

        T DestroyWall();

        T DestroyDoor();

        T DestroyWindow();

        T DestroyRoof();

        T DestroyGarage();

        T DestroyGarden();


    }

    public abstract class Builder<T> : IBuilder<T>
    {
        protected virtual void GetActionInfo(string action, string part)
        {
             Console.WriteLine($"{action} {part}");
        }
        protected Product<T> product { get; set;} 
        public abstract T BuildWall();
        public abstract T BuildDoor();
        public abstract T BuildWindow();
        public abstract T BuildRoof();
        public abstract T BuildGarage();
        public abstract T BuildGarden();
        public abstract T DestroyWall();
        public abstract T DestroyDoor();
        public abstract T DestroyWindow();
        public abstract T DestroyRoof(); 
        public abstract T DestroyGarage();
        public abstract T DestroyGarden();

    }

    public class WoodHouseBuilder : Builder<string>
    {
        public WoodHouseBuilder()
        {
            product = new WoodProduct();
        }
        public override string BuildWall()
        {
            GetActionInfo("Build Wall: ", "Wooden Wall");
            product.AddPart("Wooden Wall");
            return "Wooden Wall";
        }
        public override string BuildDoor()
        {
            GetActionInfo("Build Door: ", "Wooden Door");
            product.AddPart("Wooden Door");
            return "Wooden Door";
        }
        public override string BuildWindow()
        {
            GetActionInfo("Build Window: ", "Wooden Window");
            product.AddPart("Wooden Window");
            return "Wooden Window";
        }
        public override string BuildRoof()
        {
            GetActionInfo("Build Roof: ", "Wooden Roof");
            product.AddPart("Wooden Roof");
            return "Wooden Roof";
        }
        public override string BuildGarage()
        {
            GetActionInfo("Build Garage: ", "Wooden Garage");
            product.AddPart("Wooden Garage");
            return "Wooden Garage";
        }
        public override string BuildGarden()
        {
            GetActionInfo("Build Garden: ", "Wooden Garden");
            product.AddPart("Wooden Garden");
            return "Wooden Garden";
        }
        public override string DestroyWall()
        {
            GetActionInfo("Destroy Wall: ", "Wooden Wall");
            product.RemovePart("Wooden Wall");
            return "Wooden Wall";
        }
        public override string DestroyDoor()
        {
            GetActionInfo("Destroy Door: ", "Wooden Door");
            product.RemovePart("Wooden Door");
            return "Wooden Door";
        }
        public override string DestroyWindow()
        {
            GetActionInfo("Destroy Window: ", "Wooden Window");
            product.RemovePart("Wooden Window");
            return "Wooden Window";
        }
        public override string DestroyRoof()
        {
            GetActionInfo("Destroy Roof: ", "Wooden Roof");
            product.RemovePart("Wooden Roof");
            return "Wooden Roof";
        }
        public override string DestroyGarage()
        {
            GetActionInfo("Destroy Garage: ", "Wooden Garage");
            product.RemovePart("Wooden Garage");
            return "Wooden Garage";
        }
        public override string DestroyGarden()
        {
            GetActionInfo("Destroy Garden: ", "Wooden Garden");
            product.RemovePart("Wooden Garden");
            return "Wooden Garden";
        }
    }

    public class MetalHouseBuilder : Builder<string>
    {
        public MetalHouseBuilder()
        {
            product = new MetalProduct();
        }
        public override string BuildWall()
        {
            GetActionInfo("Build Wall: ", "Metal Wall");
            product.AddPart("Metal Wall");
            return "Metal Wall";
        }
        public override string BuildDoor()
        {
            GetActionInfo("Build Door: ", "Metal Door");
            product.AddPart("Metal Door");
            return "Metal Door";
        }
        public override string BuildWindow()
        {
            GetActionInfo("Build Window: ", "Metal Window");
            product.AddPart("Metal Window");
            return "Metal Window";
        }
        public override string BuildRoof()
        {
            GetActionInfo("Build Roof: ", "Metal Roof");
            product.AddPart("Metal Roof");
            return "Metal Roof";
        }
        public override string BuildGarage()
        {
            GetActionInfo("Build Garage: ", "Metal Garage");
            product.AddPart("Metal Garage");
            return "Metal Garage";
        }
        public override string BuildGarden()
        {
            GetActionInfo("Build Garden: ", "Metal Garden");
            product.AddPart("Metal Garden");
            return "Metal Garden";
        }
        public override string DestroyWall()
        {
            GetActionInfo("Destroy Wall: ", "Metal Wall");
            product.RemovePart("Metal Wall");
            return "Metal Wall";
        }
        public override string DestroyDoor()
        {
            GetActionInfo("Destroy Door: ", "Metal Door");
            product.RemovePart("Metal Door");
            return "Metal Door";
        }
        public override string DestroyWindow()
        {
            GetActionInfo("Destroy Window: ", "Metal Window");
            product.RemovePart("Metal Window");
            return "Metal Window";
        }
        public override string DestroyRoof()
        {
            GetActionInfo("Destroy Roof: ", "Metal Roof");
            product.RemovePart("Metal Roof");
            return "Metal Roof";
        }
        public override string DestroyGarage()
        {
            GetActionInfo("Destroy Garage: ", "Metal Garage");
            product.RemovePart("Metal Garage");
            return "Metal Garage";
        }
        public override string DestroyGarden()
        {
            GetActionInfo("Destroy Garden: ", "Metal Garden");
            product.RemovePart("Metal Garden");
            return "Metal Garden";
        }
    }
}
