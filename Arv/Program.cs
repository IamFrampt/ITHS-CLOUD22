//var myAnimal = new Animal();

//var myCat = new Cat();

Animal myCat = new Cat() { Name = "Norman" };
Animal myDog = new Dog() { Name = "Doggo" };
Animal myHuman = new Human() { Name = "Fredrik" };

SpeakFiveTimes(myCat);
Console.WriteLine();
SpeakFiveTimes(myDog);
Console.WriteLine();
SpeakFiveTimes(myHuman);
Console.WriteLine();

Console.WriteLine(myCat);
Console.WriteLine(myDog);
Console.WriteLine(myHuman);

SpeakFiveTimes(5.3f);


void SpeakFiveTimes(object obj)
{
    for (int i = 0; i < 5; i++)
    {
        //Animal animal = obj as Animal;

        //Animal animal = (Animal)obj;
        //Animal animal = obj as Animal;

        /*if(animal is not null)
         {
            animal.Speak();
         }*/

        if (obj is Animal animal)
            animal.Speak();
        else if (obj is float f)
            Console.WriteLine($"Float value: {f}");
    }
}

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void Speak();

    public override string ToString()
    {
        return $"My name is {Name}";
    }
}
class Mammal : Animal
{
    public override void Speak()
    {
        Console.WriteLine("I'm a mammal.");
    }
}
class Cat : Mammal
{
    public override void Speak()
    {
        Console.WriteLine("I'm a cat!");
    }

    public override string ToString()
    {
        return base.ToString() + $". I'm the coolest cat alive.";
    }
}
class Dog : Mammal
{
    public override void Speak()
    {
        Console.WriteLine("I'm a dog!");
    }
    public override string ToString()
    {
        return base.ToString() + $" and I'm a fat lazy dog.";
    }
}
class Human : Mammal
{
    public override void Speak()
    {
        Console.WriteLine("I'm a Human!");
    }
    public override string ToString()
    {
        return base.ToString() + $" and I'm a Slave.";
    }
}