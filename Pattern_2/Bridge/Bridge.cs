using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Bridge
{
    public enum BreadType
    {
        White,
        Black
    }
    public interface IBreadType
    {
        string Name { get; }
        BreadType breadType {  get; }
        string GetBreadType();

    }
    public class BlackBread : IBreadType
    {
        public string Name => BreadType.Black.ToString();

        public BreadType breadType => BreadType.Black;

        public string GetBreadType()
        {
            return Name;
        }
    }

    public class WhiteBread : IBreadType
    {
        public string Name => BreadType.White.ToString();
        public BreadType breadType => BreadType.White;
        public string GetBreadType()
        {
            return Name;
        }
    }
    public abstract class Bread
    {
        public string Name { set; get; }
        public IBreadType BreadType { set; get; }
        public abstract string GetBread();
    }

    public class BreadWhite : Bread
    {
        public BreadWhite(string name)
        {
            this.Name = name;
            this.BreadType = new WhiteBread();
        }

        public override string GetBread()
        {
            return $"{Name} with {BreadType.GetBreadType()} type";
        }
    }

    public class BreadBlack : Bread
    {
        public BreadBlack(string name)
        {
            this.Name = name;
            this.BreadType = new BlackBread();
        }
        public override string GetBread()
        {
            return $"{Name} with {BreadType.GetBreadType()} type";
        }
    }

    
}
