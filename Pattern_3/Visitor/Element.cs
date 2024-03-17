using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
    public abstract class Element : IElement
    {
        protected string _name;
        public Element(string name)
        {
            _name = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
        public abstract string VisitPlace();
    }
    public class CafeElement  : Element
    {
        public CafeElement(string name) : base(name)
        {
        }
        public override string VisitPlace()
        {
            return $"Cafe {_name} was visited!";
        }
    }
    public class MuseumElement : Element
    {
        public MuseumElement(string name) : base(name)
        {
        }
        public override string VisitPlace()
        {
            return $"Museum {_name} was visited!";
        }
    }
    public class ParkElement : Element
    {
        public ParkElement(string name) : base(name)
        {
        }
        public override string VisitPlace()
        {
            return $"Park {_name} was visited!";
        }
    }
    public class CinemaElement : Element
    {
        public CinemaElement(string name) : base(name)
        {
        }
        public override string VisitPlace()
        {
            return $"Cinema {_name} was visited!";
        }
    }
    public class OfficeElement : Element
    {
        public OfficeElement(string name) : base(name)
        {
        }
        public override string VisitPlace()
        {
            return $"Office {_name} was visited!";
        }
    }
    public class HomeElement : Element
    {
        public HomeElement(string name) : base(name)
        {
        }
        public override string VisitPlace()
        {
            return $"Home {_name} was visited!";
        }
    }



}
