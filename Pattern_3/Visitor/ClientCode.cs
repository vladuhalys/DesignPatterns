using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Visitor
{
    public class ClientCode
    {
        public void Main()
        {
            List<Element> touristPlaces = new List<Element>
            {
                new CafeElement("PanCake"),
                new MuseumElement("Pirogova"),
                new ParkElement("Lisopark"),
                new CinemaElement("Cinema City")
            };

            List<Element> dayliPlaces = new List<Element>
            {
                new OfficeElement("Five System Development`s Office"),
                new HomeElement("Avalon 5")
            };
            TouristVisitor touristVisitor = new TouristVisitor(touristPlaces);
            DayliVisitor dayliVisitor = new DayliVisitor(dayliPlaces);

            touristVisitor.visitCafe();
            touristVisitor.visitMuseum();
            touristVisitor.visitPark();
            touristVisitor.visitCinema();

            dayliVisitor.visitOffice();
            dayliVisitor.visitHome();

            Console.ReadKey();
        }
    }
}
