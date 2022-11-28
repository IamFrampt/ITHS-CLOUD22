using ObserverDemo.Observer_pattern.Interfaces;

namespace ObserverDemo.Observer_pattern
{
    internal class Subscriber : IObserver
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void Update(string title)
        {
            Console.WriteLine($"There's a new blog update for you {_name}! '{title}'");
        }
    }
}
