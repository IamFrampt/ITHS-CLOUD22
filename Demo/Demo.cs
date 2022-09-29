//bool isValid = false;
//do
//{
//    try
//    {
//        Console.Write("Skriv in ett tal: ");
//        int input = Int32.Parse(Console.ReadLine());
//        Console.WriteLine(input * 10);
//        isValid = true;
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message + "Try again.");
//    }

//} while (!isValid);

#region Body Expression
//Human me = new Human();

//me.BMI = 25;
//double myDouble = me.BMI;
//Console.WriteLine(me);

//class Human
//{
//    private double _BMI = 25.0;

//    public double BMI
//    {
//        get => _BMI;
//        set => _BMI = value;
//    }

//    public override string ToString() => $"I'm a Human with BMI: {_BMI}.";
//}
#endregion

#region Pattern
//int number = 3;

//string text = number switch
//{
//    1 => "Ett",
//    2 => "Två",
//    3 => "Tre",
//};

//Console.WriteLine(text);
//Console.WriteLine();

//Cat myCat = new Cat() { Name = "Norman" };

//string text2 = myCat switch
//{
//    { Name: "Norman" } => "This is Norman",
//    { Name: "Findus" } => "Findus says Hello!",
//    _ => "This is a Cat."
//};

//Console.WriteLine(text2);
//Console.WriteLine();

//public class Cat
//{
//    public string Name { get; set; }
//}
#endregion

#region Interface
//using System.Collections;

//using (var myCat = new Cat("Norman",3.6))
//{
//    Console.WriteLine($"The name of the cat is {myCat}. The weight is {myCat.Weight}.");
//}
//Console.WriteLine();

//Cat[] cats = {
//    new Cat("Norman",3.6),
//    new Cat("Batman", 4),
//    new Cat("Spiderman", 3.2),
//    new Cat("Ironman", 3.4),
//    new Cat("Aquaman", 3.5),
//    new Cat("WonderWoman", 4.4),
//};

//Array.Sort(cats);

//foreach (Cat c in cats)
//{
//    Console.WriteLine($"Name of cat: {c.Name}. Weight is {c.Weight}kg");
//    if(c is IExplodable explodable)
//    {
//        explodable.Explode();
//    }
//    Console.WriteLine();
//}

//class Cat : IDisposable, IComparable, IExplodable, IEnumerable
//{
//    public string Name { get; set; }
//    public double Weight { get; set; }
//    private double _speed;
//    public double ExplosionVelocity { get => _speed ; set => _speed = value*Math.PI; }

//    Random rand = new Random();

//    public Cat(string name, double weight)
//    {
//        Name = name;
//        Weight = weight;
//        _speed = rand.Next(200);

//    }

//    public void Dispose()
//    {
//        //throw new NotImplementedException();
//        Console.WriteLine($"{Name} is disposed.");
//    }

//    public int CompareTo(object? obj)
//    {
//        return Name.CompareTo((obj as Cat).Name);
//        //return Weight.CompareTo((obj as Cat).Weight);
//    }

//    public void Explode()
//    {
//        Console.WriteLine($"BOOOM! {Name} flew {ExplosionVelocity} meters.");
//    }

//    public IEnumerator GetEnumerator()
//    {
//        throw new NotImplementedException();
//    }
//}


//interface IExplodable
//{
//    public double ExplosionVelocity { get; set; }
//    public void Explode();
//}
#endregion

Cage<string> stringCage = new Cage<string>("hello");
Cage<int> intCage = new Cage<int>(3);
DoubleCage<bool,int> boolCage = new DoubleCage<bool,int>(true,45);

Console.WriteLine(stringCage.Inhabitant);
Console.WriteLine(intCage.Inhabitant);
intCage.Inhabitant = 1;
Console.WriteLine(boolCage.InhabitantA);
Console.WriteLine(boolCage.InhabitantB);




Console.WriteLine();
PrintFiveTimes(true);

void PrintFiveTimes<T>(T item)
{
	for (int i = 0; i < 5; i++)
	{
		Console.WriteLine(item);
	}
}

class Cage<T>
{
	public T Inhabitant { get; set; }

	public Cage(T item)
	{
		Inhabitant = item;
	}
}

class DoubleCage<T,T2>
{
    public T InhabitantA { get; set; }
    public T2 InhabitantB { get; set; }

    public DoubleCage(T a,T2 b)
    {
        InhabitantA = a;
        InhabitantB = b;
    }
}