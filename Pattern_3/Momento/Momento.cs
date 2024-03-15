using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Momento
{
    public interface IMomento
    {
        void SetState(List<object> arg);
        List<object> GetState();
    }

    public class WatterMomento : Watter, IMomento
    {
        public WatterMomento(int temperature, int volume, string watterState) : base(temperature, volume, watterState)
        {}
        public WatterMomento(Watter water) : base(water)
        { }
        public List<object> GetState()
        {
            return new List<object> { Temperature, Volume, State };
        }
        public void SetState(List<object> arg)
        {
            Temperature = (int)arg[0];
            Volume = (int)arg[1];
            State = (string)arg[2];
        }
        public override string ToString()
        {
            return $"Momento: Temperature: {Temperature}, Volume: {Volume}, State: {State}";
        }
    }
}
