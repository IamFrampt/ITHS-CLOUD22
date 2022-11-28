//MyDelegate del = PrintText1;
//del += PrintText2;
//del.Invoke("Hello World");
//Console.WriteLine();

//del += PrintText1;
//del.Invoke("Hello Again");
//Console.WriteLine();

//del -= PrintText1;
//del.Invoke("Third times the charm.");

//void PrintText1(string s)
//{
//    Console.WriteLine($"PrintText1: {s.ToLower()}");
//}


//void PrintText2(string s)
//{
//    Console.WriteLine($"PrintText2: {s.ToUpper()}");
//}

//delegate void MyDelegate(string s);

using Events;

Publisher publisher = new Publisher();
Subscriber sub1 = new Subscriber("Mikael");
Subscriber sub2 = new Subscriber("Paulina");
Subscriber sub3 = new Subscriber("Ioannis");
Subscriber sub4 = new Subscriber("Pontus");

publisher.OnMessage += sub1.OnMessageReceived;
publisher.OnMessage += sub2.OnMessageReceived;
publisher.OnMessage += sub3.OnMessageReceived;

publisher.SendMessage("Subscribe to Pewdiepie!");
Console.WriteLine();

publisher.OnMessageComplaint += sub3.OnComplaintMessageReceived;

publisher.ComplaintMessage("T-Series Sucks!");



