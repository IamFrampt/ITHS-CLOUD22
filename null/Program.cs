string myString = null;
Nullable<int> myInt = null;
int? myInt2 = null;


//if (myInt is not null)
//    Console.WriteLine(myInt);
//else
//    Console.WriteLine("No value.");


//if(myInt.HasValue)
//{
//    Console.WriteLine($"myInt has value: {myInt.Value}");
//}
//else
//    Console.WriteLine("No value.");


Person fredrik = new() { Name =  "fredrik"};
Person joel = new() { Name = "joel" };
Person adam = new() { Name = "adam" };

fredrik.bestFriend = joel;
joel.bestFriend = adam;
adam.bestFriend = fredrik;

Console.WriteLine(fredrik.bestFriend.bestFriend.Name);
class Person
{
    public string Name { get; set; }
    public Person bestFriend { get; set; }
}
