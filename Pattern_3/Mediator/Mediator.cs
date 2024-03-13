using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Mediator
{
    public class Mediator : IMediator
    {
        private Dictionary<String, BaseComponent> Components { get; set; }
        public Mediator()
        {
            Components = new Dictionary<String, BaseComponent>();
        }
        public void AddComponent(String key,BaseComponent component)
        {
            Components.Add(key, component);
        }
        public void RemoveComponent(String key)
        {
            Components.Remove(key);
        }
        public void Notify(object sender)
        {
            String key = sender.ToString()!;
            try
            {
                Components[key].ReactOn(sender);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
