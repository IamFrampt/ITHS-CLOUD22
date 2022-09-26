Cat myCat = new Cat("Norman");
//var myCat = new Cat();
//Cat myCat = new();
//myCat.Name = "Norman";
myCat.Age = 3;

Cat myOtherCat = new Cat("Rubert", 5);

//Console.WriteLine($"Hello, {myCat.Name}!. He's {myCat.Age} years old.");
//Console.WriteLine($"Hello, {myOtherCat.Name}!. He's {myOtherCat.Age} year old.");

myCat.Greeting();
myOtherCat.Greeting("Wazzzup");

myOtherCat.AgeOneYear();
myOtherCat.Greeting("Wazzzup");


class Cat
{
    public string Name = string.Empty;
    public int Age = 1;

    //Konstruktor
    public Cat(string name)
    {
        this.Name = name;
    }
    public Cat(string name,int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void Greeting()
    {
        Greeting("Hello");
    }
    public void Greeting(string greeting)
    {
        Console.WriteLine($"{greeting}!, my name is {this.Name}.");
        PrintAge();
    }
    
    private void PrintAge()
    {
        //Console.WriteLine($"I'm {this.Age} years old.");
        Console.WriteLine($"I'm {this.Age} year{(this.Age <= 1 ? "" : "s")} old.");

    }
    public void AgeOneYear()
    {
        this.Age++;
    }
}

//Dog myDog = new Dog() { Name = "Hund", Breed = "Wiener Dog", Age = 12, Weight = 14.5 };
//Dog myFatDog = new Dog() { Name = "Katt", Breed = "Chihuahua", Age = 5, Weight = 3 };

//Console.WriteLine($"Hello! My dog's name is {myDog.Name}. He's a {myDog.Breed}, His weight is {myDog.Weight}kg and he's {myDog.Age} years old.");
//Console.WriteLine($"Hello! My dog's name is {myFatDog.Name}. He's a {myFatDog.Breed}, His weight is {myFatDog.Weight}kg and he's {myFatDog.Age} years old.");

//class Dog
//{
//    public string Name;
//    public int Age;
//    public string Breed;
//    public double Weight;
//}