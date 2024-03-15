using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Observer
{
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

            Dictionary<string, Manager<string>> managers = new Dictionary<string, Manager<string>>()
            {
                { "YouTube", new Manager<string>("YouTube")},
                { "Twich", new Manager<string>("Twich")},
                { "Netflix", new Manager<string>("Netflix")}
            };

            managers["YouTube"].AddPublisher(publisher1);
            managers["YouTube"].AddPublisher(publisher2);
            managers["YouTube"].AddPublisher(publisher3);
            managers["YouTube"].AddPublisher(publisher4);
            managers["YouTube"].AddPublisher(publisher5);

            managers["Twich"].AddPublisher(publisher1);
            managers["Twich"].AddPublisher(publisher4);
            managers["Twich"].AddPublisher(publisher5);

            managers["Netflix"].AddPublisher(publisher5);

            managers["YouTube"].AddSubscriberToPublishers(subscriber1);
            managers["YouTube"].AddSubscriberToPublishers(subscriber2);
            managers["YouTube"].AddSubscriberToPublishers(subscriber3);
            managers["YouTube"].AddSubscriberToPublishers(subscriber4);
            managers["YouTube"].AddSubscriberToPublishers(subscriber5);

            managers["Twich"].AddSubscriberToPublishers(subscriber1);
            managers["Twich"].AddSubscriberToPublishers(subscriber4);
            managers["Twich"].AddSubscriberToPublishers(subscriber5);

            managers["Netflix"].AddSubscriberToPublisher(subscriber5, "Anime Band Studio");
            managers["Netflix"].AddSubscriberToPublisher(subscriber1, "Anime Band Studio");
            managers["Netflix"].AddSubscriberToPublisher(subscriber2, "Anime Band Studio");

            managers["YouTube"].NotifyPublisher("New video about C++", "Cool C++ Programing");
            managers["YouTube"].NotifyPublisher("New video about C#", "C# for beginners");
            managers["YouTube"].NotifyPublisher("New video about Java", "Java for everyone");

            managers["Twich"].NotifyPublisher("New stream about C++", "Cool C++ Programing");
            managers["Twich"].NotifyPublisher("New stream about Films", "Film Geeks");
            managers["Twich"].NotifyPublisher("New stream about Anime", "Anime Band Studio");

            managers["Netflix"].NotifyPublisher("Berserk 1 season 1 series", "Anime Band Studio");

            managers["YouTube"].RemoveSubscriberFromPublisher(subscriber2, "Cool C++ Programing");
            managers["YouTube"].RemoveSubscriberFromPublisher(subscriber3, "Cool C++ Programing");


            managers["YouTube"].NotifyPublisher("Loops C++", "Cool C++ Programing");
        }
    }
}
