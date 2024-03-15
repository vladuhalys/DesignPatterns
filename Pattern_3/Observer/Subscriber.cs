
namespace Pattern_3.Observer
{
    public interface ISubscriber<T>
    {
        public string Name { set; get; }
        bool isSubscribe();
        string update(T data);
        void changeSubscription();
    }

    public class Subscriber<T> : ISubscriber<T>
    {
        public string Name { set; get; }
        private bool isSubscribed = false;
        public bool isSubscribe()
        {
            return isSubscribed;
        }
        public string update(T data)
        {
            return $"Subscriber {Name} gets: {data}.";
        }
        public void changeSubscription()
        {
            isSubscribed = !isSubscribed;
        }
        public Subscriber(string name)
        {
            Name = name;
        }
    }
}