namespace Pattern_3.Observer
{
    public interface IPublisher<T>
    {
        public void AddSubscriber(Subscriber<T> subscriber);
        public void RemoveSubscriber(Subscriber<T> subscriber);
        public void NotifySubscribers(T newData);
        public void ChangeState(T state);
    }
    public class Publisher<T> : IPublisher<T>
    {
        public string Name { set; get; }
        private List<Subscriber<T>> _subscribers;
        private T _state;
        public Publisher()
        {
            _subscribers = new List<Subscriber<T>>();
        }
        public Publisher(string name) : this()
        {
            this.Name = name;
        }
        public void AddSubscriber(Subscriber<T> subscriber)
        {
            Console.WriteLine($"Subscriber {subscriber.Name} is added to {Name}.");
            _subscribers.Add(subscriber);
            Console.WriteLine();
        }
        public void RemoveSubscriber(Subscriber<T> subscriber)
        {
            Console.WriteLine($"Subscriber {subscriber.Name} is removed from {Name}.");
            _subscribers.Remove(subscriber);
            Console.WriteLine();
        }
        public void NotifySubscribers(T newData)
        {
            Console.WriteLine($"Publisher {Name} notifies its subscribers:");
            foreach (var subscriber in _subscribers)
            {
                Console.WriteLine(subscriber.update(newData));
            }
            Console.WriteLine();
        }
        public void ChangeState(T state)
        {
            Console.WriteLine($"Publisher {Name} changes its state to {state}.");
            _state = state;
            NotifySubscribers(_state);
            Console.WriteLine();
        }
    }
}
