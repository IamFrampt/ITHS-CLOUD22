using ObserverDemo.Observer_pattern;
using ObserverDemo.Observer_pattern.Interfaces;

ISubject blog = new Blog();
ISubject channel = new Channel();

IObserver Mikael = new Subscriber("Mikael");
IObserver Kalle = new Subscriber("Kalle");
IObserver Pelle = new Subscriber("Pelle");


blog.Subscribe(Mikael);
blog.Subscribe(Kalle);
blog.Subscribe(Pelle);

channel.Subscribe(Pelle);

blog.Upload($"Great Breakfast!");
channel.Upload("Cooking bacon really fast with this easy trick!");

blog.Unsubscribe(Kalle);
blog.Unsubscribe(Pelle);

blog.Upload($"Amazing Dinner!");


