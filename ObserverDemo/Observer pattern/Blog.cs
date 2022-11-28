using ObserverDemo.Observer_pattern.Interfaces;

namespace ObserverDemo.Observer_pattern
{
    public class Blog : ISubject
    {
        private ICollection<IObserver> Subscribers { get; } = new List<IObserver>();

        public void NotifySubscribers(string title)
        {
            foreach(var sub in Subscribers)
            {
                sub.Update(title);
            }
        }

        public void Subscribe(IObserver sub)
        {
            Subscribers.Add(sub);
        }

        public void Unsubscribe(IObserver sub)
        {
            Subscribers.Remove(sub);
        }

        public void Upload(string title)
        {
            NotifySubscribers(title);
        }
    }
}
