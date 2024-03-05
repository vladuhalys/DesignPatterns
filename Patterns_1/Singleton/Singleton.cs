using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.Singleton
{
    public class Singleton
    {
        private static Singleton? _instance;
        private static object _lock = new object();
        private Singleton() { }
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
        public void SomeBusinessLogic()
        {
            Console.WriteLine("Hello Singelton!");
        }
    }
}
