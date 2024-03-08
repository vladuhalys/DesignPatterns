using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Adapter
{
    public enum MoneyFormat
    {
        USD,
        EUR,
        UAH
    }
    public enum MoneyCoin
    {
        Cent,
        KOP
    }
    public interface IMoneyTransformer
    {
        string DoubleToStringMoney(double money, MoneyFormat moneyFormat, MoneyCoin moneyCoin);
    }

  
    class DoubleMoneyFormat
    {
        public double Money { get; set; } //9000.45
    }

    class Adapter : IMoneyTransformer
    {
        private readonly DoubleMoneyFormat _adaptee;

        public Adapter(DoubleMoneyFormat adaptee)
        {
            this._adaptee = adaptee;
        }

        public string DoubleToStringMoney(double money, MoneyFormat moneyFormat, MoneyCoin moneyCoin)
        {
            string part_1 = ((int)money).ToString();
            string part_2 = ((int)((money - (int)money) * 100)).ToString();
            string result = $"{part_1} {moneyFormat} {part_2} {moneyCoin}";
            return result;
        }
    }
}
