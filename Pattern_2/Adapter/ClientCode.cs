using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Adapter
{
    public class ClientCode
    {
        public void Main()
        {
            try
            {
                DoubleMoneyFormat adaptee = new DoubleMoneyFormat();
                Console.Write("Enter money:");
                adaptee.Money = double.Parse(Console.ReadLine() ?? "0");
                IMoneyTransformer adapter = new Adapter(adaptee);
                string result = adapter.DoubleToStringMoney(adaptee.Money, MoneyFormat.USD, MoneyCoin.Cent);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
