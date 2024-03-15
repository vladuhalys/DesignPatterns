using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Observer
{
    public interface IManager<T>
    {
        public void AddPublisher(Publisher<T> publisher);
        public void RemovePublisher(Publisher<T> publisher);
        public void NotifyPublishers(T newData);
        public void NotifyPublisher(T newData, string name);
        public void AddSubscriberToPublishers(Subscriber<T> subscriber);
        public void AddSubscriberToPublisher(Subscriber<T> subscriber, string name);
        public void RemoveSubscriberFromPublisher(Subscriber<T> subscriber, string name);
        public void RemoveSubscriberFromPublishers(Subscriber<T> subscriber);
    }
    public class Manager<T> : IManager<T>
    {
        public string Name { get; set; }
        private List<Publisher<T>> _publishers;
        public Manager()
        {
            _publishers = new List<Publisher<T>>();
        }
        public Manager(string name) : this()
        {
            Name = name;
        }
        public void AddPublisher(Publisher<T> publisher)
        {
            Console.WriteLine($"Publisher {publisher.Name} is added to {Name}.");
            _publishers.Add(publisher);
            Console.WriteLine();
        }
        public void RemovePublisher(Publisher<T> publisher)
        {
            Console.WriteLine($"Publisher {publisher.Name} is removed from {Name}.");
            _publishers.Remove(publisher);
            Console.WriteLine();
        }
        public void NotifyPublishers(T newData)
        {
            foreach (var publisher in _publishers)
            {
                Console.WriteLine($"{publisher.Name} start Notify:");
                publisher.NotifySubscribers(newData);
                Console.WriteLine();
            }
        }
        public void NotifyPublisher(T newData, string name)
        {
            foreach (var publisher in _publishers)
            {
               
                if (publisher.Name == name)
                {
                    Console.WriteLine($"{publisher.Name} change state:");
                    publisher.ChangeState(newData);
                    Console.WriteLine();
                }
            }
        }
        public void AddSubscriberToPublishers(Subscriber<T> subscriber)
        {
            foreach (var publisher in _publishers)
            {
                Console.WriteLine($"{publisher.Name} added new subscriber: "); 
                publisher.AddSubscriber(subscriber);
                Console.WriteLine();
            }
        }
        public void AddSubscriberToPublisher(Subscriber<T> subscriber, string name)
        {
            foreach (var publisher in _publishers)
            {
                if (publisher.Name == name)
                {
                    Console.WriteLine($"{publisher.Name} added new subscriber {subscriber.Name}: ");
                    publisher.AddSubscriber(subscriber);
                    Console.WriteLine();
                }
            }
        }
        public void RemoveSubscriberFromPublisher(Subscriber<T> subscriber, string name)
        {
            foreach (var publisher in _publishers)
            {
                if (publisher.Name == name)
                {
                    Console.WriteLine($"{publisher.Name} removed subscriber: ");
                    publisher.RemoveSubscriber(subscriber);
                    Console.WriteLine();
                }
            }
        }
        public void RemoveSubscriberFromPublishers(Subscriber<T> subscriber)
        {
            foreach (var publisher in _publishers)
            {
                Console.WriteLine($"{publisher.Name} removed subscriber: ");
                publisher.RemoveSubscriber(subscriber);
                Console.WriteLine();
            }
        }
    }
}
