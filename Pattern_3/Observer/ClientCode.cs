using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Observer
{
    enum ManagerType
    {
        YouTube,
        Twich,
        Netflix
    }
    public class ClientCode
    {
        public void Main()
        {
            Subscriber<string> subscriber1 = new Subscriber<string>("Bob Smith");
            Subscriber<string> subscriber2 = new Subscriber<string>("Alex Lowman");
            Subscriber<string> subscriber3 = new Subscriber<string>("John Dou");
            Subscriber<string> subscriber4 = new Subscriber<string>("Victor Kurz");
            Subscriber<string> subscriber5 = new Subscriber<string>("Kate Midletow");

            Publisher<string> publisher1 = new Publisher<string>("Cool C++ Programing");
            Publisher<string> publisher2 = new Publisher<string>("C# for beginners");
            Publisher<string> publisher3 = new Publisher<string>("Java for everyone");
            Publisher<string> publisher4 = new Publisher<string>("Film Geeks");
            Publisher<string> publisher5 = new Publisher<string>("Anime Band Studio");

            Dictionary<ManagerType, Manager<string>> managers = new Dictionary<ManagerType, Manager<string>>()
            {
                { ManagerType.YouTube, new Manager<string>("YouTube")},
                { ManagerType.Twich, new Manager<string>("Twich")},
                { ManagerType.Netflix, new Manager<string>("Netflix")}
            };

            managers[ManagerType.YouTube].AddPublisher(publisher1);
            managers[ManagerType.YouTube].AddPublisher(publisher2);
            managers[ManagerType.YouTube].AddPublisher(publisher3);
            managers[ManagerType.YouTube].AddPublisher(publisher4);
            managers[ManagerType.YouTube].AddPublisher(publisher5);

            managers[ManagerType.Twich].AddPublisher(publisher1);
            managers[ManagerType.Twich].AddPublisher(publisher4);
            managers[ManagerType.Twich].AddPublisher(publisher5);

            managers[ManagerType.Netflix].AddPublisher(publisher5);

            managers[ManagerType.YouTube].AddSubscriberToPublishers(subscriber1);
            managers[ManagerType.YouTube].AddSubscriberToPublishers(subscriber2);
            managers[ManagerType.YouTube].AddSubscriberToPublishers(subscriber3);
            managers[ManagerType.YouTube].AddSubscriberToPublishers(subscriber4);
            managers[ManagerType.YouTube].AddSubscriberToPublishers(subscriber5);

            managers[ManagerType.Twich].AddSubscriberToPublishers(subscriber1);
            managers[ManagerType.Twich].AddSubscriberToPublishers(subscriber4);
            managers[ManagerType.Twich].AddSubscriberToPublishers(subscriber5);

            managers[ManagerType.Netflix].AddSubscriberToPublisher(subscriber5, "Anime Band Studio");
            managers[ManagerType.Netflix].AddSubscriberToPublisher(subscriber1, "Anime Band Studio");
            managers[ManagerType.Netflix].AddSubscriberToPublisher(subscriber2, "Anime Band Studio");

            managers[ManagerType.YouTube].NotifyPublisher("New video about C++", "Cool C++ Programing");
            managers[ManagerType.YouTube].NotifyPublisher("New video about C#", "C# for beginners");
            managers[ManagerType.YouTube].NotifyPublisher("New video about Java", "Java for everyone");

            managers[ManagerType.Twich].NotifyPublisher("New stream about C++", "Cool C++ Programing");
            managers[ManagerType.Twich].NotifyPublisher("New stream about Films", "Film Geeks");
            managers[ManagerType.Twich].NotifyPublisher("New stream about Anime", "Anime Band Studio");

            managers[ManagerType.Netflix].NotifyPublisher("Berserk 1 season 1 series", "Anime Band Studio");

            managers[ManagerType.YouTube].RemoveSubscriberFromPublisher(subscriber2, "Cool C++ Programing");
            managers[ManagerType.YouTube].RemoveSubscriberFromPublisher(subscriber3, "Cool C++ Programing");


            managers[ManagerType.YouTube].NotifyPublisher("Loops C++", "Cool C++ Programing");
        }
    }
}
