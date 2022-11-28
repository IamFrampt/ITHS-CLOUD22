using ObserverDemo.Observer_pattern.Interfaces;

namespace ObserverDemo.Observer_pattern;

public class Channel: ISubject
{
    public ICollection<IObserver> Subscribers { get; } = new List<IObserver>();

    
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

    public void NotifySubscribers(string title)
    {
        foreach (var sub in Subscribers)
        {
            sub.Update(title);
        }
    }
}