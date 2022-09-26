public class Dog
{
    public string Name;
    //public int Age;
    public string Breed;
    public double Weight;


    public void PrintName()
    {
        Console.WriteLine($"Hello, My name is {Name}");
    }
    public void PrintBreed()
    {
        Console.WriteLine($"I'm a {Breed}");
    }

}
