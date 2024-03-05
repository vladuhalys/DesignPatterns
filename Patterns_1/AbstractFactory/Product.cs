using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.AbstractFactory
{
    public interface ISmartphone
    {
        string Call();
        string Update();
        String Message();
    }

    public abstract class Smartphone : ISmartphone
    {
        public abstract string Call();
        public abstract string Update();
        public abstract string Message();
    }
    public class Iphone : Smartphone
    {
        public override string Call()
        {
            return "Iphone is calling";
        }
        public override string Update()
        {
            return "Iphone is updating to new version";
        }
        public override string Message()
        {
            return "Iphone is messaging by protocol iMassage!";
        }
    }

    public class Redmi : Smartphone
    {
        public override string Call()
        {
            return "Redmi is calling";
        }
        public override string Update()
        {
            return "Redmi is updating to new version";
        }
        public override string Message()
        {
            return "Redmi is messaging by protocol SMS!";
        }
    }

    public class Galaxy : Smartphone
    {
        public override string Call()
        {
            return "Galaxy is calling";
        }
        public override string Update()
        {
            return "Galaxy is updating to new version";
        }
        public override string Message()
        {
            return "Galaxy is messaging by protocol SMS!";
        }
    }


    public interface ITablet
    {
        string Call();
        string Update();
        String Watch();
    }

    public abstract class Tablet : ITablet
    {
        public abstract string Call();
        public abstract string Update();
        public abstract string Watch();
    }
    public class Ipad : Tablet
    {
        public override string Call()
        {
            return "Ipad is calling";
        }
        public override string Update()
        {
            return "Ipad is updating to new version";
        }
        public override String Watch()
        {
            return "Watch some film by Ipad";
        }
    }

    public class Tab : Tablet
    {
        public override string Call()
        {
            return "Tab is calling";
        }
        public override string Update()
        {
            return "Tab is updating to new version";
        }
        public override String Watch()
        {
            return "Watch some film by Tab";
        }
    }

    public class Mi : Tablet
    {
        public override string Call()
        {
            return "Mi is calling";
        }
        public override string Update()
        {
            return "Mi is updating to new version";
        }
        public override String Watch()
        {
            return "Watch some film by Mi";
        }
    }
}
