using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Visitor
{
    public interface IVisitor
    {
        void visit(Element element);
    }
    public abstract class Visitor : IVisitor
    {
        public void visit(Element element)
        {
            element.Accept(this);
        }
    }

    public class TouristVisitor : Visitor
    {
        private CafeElement cafe;
        private MuseumElement museum;
        private ParkElement park;
        private CinemaElement cinema;
        
        public TouristVisitor(List<Element> places)
        {
            this.cafe = (CafeElement)places[0];
            this.museum = (MuseumElement)places[1];
            this.park = (ParkElement)places[2];
            this.cinema = (CinemaElement)places[3];
        }
        public void visitCafe()
        {
            Console.WriteLine(cafe.VisitPlace());
        }
        public void visitMuseum()
        {
           
            Console.WriteLine(museum.VisitPlace());
        }
        public void visitPark()
        {
           
            Console.WriteLine(park.VisitPlace());
        }
        public void visitCinema()
        {
        
            Console.WriteLine(cinema.VisitPlace());
        }
    }

    public class DayliVisitor : Visitor
    {
        private OfficeElement officeElement;
        private HomeElement homeElement;

        public DayliVisitor(List<Element> places)
        {
            this.officeElement = (OfficeElement)places[0];
            this.homeElement = (HomeElement)places[1]; 
        }

        public void visitOffice()
        {
        
            Console.WriteLine(officeElement.VisitPlace());
        }
        public void visitHome()
        {
          
            Console.WriteLine(homeElement.VisitPlace());
        }
    }
}
