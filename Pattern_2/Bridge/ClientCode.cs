using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Bridge
{
    public class ClientCode
    {
        public void Main() {
            Bread bread = new BreadWhite("White Bread");
            Console.WriteLine(bread.GetBread());
            Bread bread2 = new BreadBlack("Black Bread");
            Console.WriteLine(bread2.GetBread());
        }
    }
}
