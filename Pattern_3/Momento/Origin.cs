using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Momento
{
    public class Watter
    {
        public int Temperature { get; set; }
        public int Volume { get; set; }
        public string State { get; set; }
        public Watter(int temperature, int volume, string state)
        {
            Temperature = temperature;
            Volume = volume;
            State = state;
        }
        public Watter(Watter water)
        {
            this.Temperature = water.Temperature;
            this.Volume = water.Volume;
            this.State = water.State;
        }

        public void SetState(int temperature, int volume, string state)
        {
            Temperature = temperature;
            Volume = volume;
            State = state;
        }
        public void ShowState()
        {
            Console.WriteLine($"Temperature: {Temperature}, Volume: {Volume}, State: {State}");
        }
        public WatterMomento SaveState()
        {
            return new WatterMomento(Temperature, Volume, State);
        }
        public void RestoreState(WatterMomento momento)
        {
            var arg = momento.GetState();
            Temperature = (int)arg[0];
            Volume = (int)arg[1];
            State = (string)arg[2];
        }
        public override string ToString()
        {
            return $"Origin: Temperature: {Temperature}, Volume: {Volume}, State: {State}";
        }
    }
}
