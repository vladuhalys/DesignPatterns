using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.AbstractFactory
{
    public interface IAbstractFactory
    {
        ISmartphone CreateSmartphone();
        ITablet CreateTablet();
    }

    public abstract class  AbstractFactory : IAbstractFactory
    {
        public abstract ISmartphone CreateSmartphone();
        public abstract ITablet CreateTablet();
    }

    class SamsungFactory : AbstractFactory
    {
        public override ISmartphone CreateSmartphone()
        {
            return new Galaxy();
        }
        public override ITablet CreateTablet()
        {
            return new Tab();
        }
    }

    // Each Concrete Factory has a corresponding product variant.
    class AppleFactory : AbstractFactory
    {
        public override ISmartphone CreateSmartphone()
        {
            return new Iphone();
        }
        public override ITablet CreateTablet()
        {
            return new Ipad();
        }
    }
    class XiaomiFactory : AbstractFactory
    {
        public override ISmartphone CreateSmartphone()
        {
            return new Redmi();
        }
        public override ITablet CreateTablet()
        {
            return new Mi();
        }
    }
}
