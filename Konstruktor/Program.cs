
using System.Diagnostics.Metrics;
using System.Reflection;

Car myVolvo = new Car("Volvo", "XC40", 2016, CarColor.Red);
Car myFord = new Car("Ford", "Fiesta", 2011);
Car myKia = new Car("Kia", "Ceed");
Car myCorvette = new Car("Corvette");

Vehicle myVehicle = new Vehicle("test");

Console.WriteLine(myVolvo.ToString());
Console.WriteLine(myFord.ToString());
Console.WriteLine(myKia.ToString());
Console.WriteLine(myCorvette.ToString());


enum CarColor
{
    Black,
    White,
    Red,
    Blue,
    Undefined
}

class Vehicle
{
    public string Name { get; set; }

    public Vehicle(string name)
    {
        Name = name;
    }
}

class Car:Vehicle
{
    public string Maker { get; set; }
    public string Model { get; set; }
    public int ProductionYear { get; set; }
    public CarColor CarColor { get; set; }

    public Car(string maker, string model, int productionYear, CarColor color) :base(maker)
    {
        Maker = maker;
        Model = model;
        ProductionYear = productionYear;
        CarColor = color;
    }
    public Car(string maker, string model, int productionYear) : this(maker,model,productionYear,CarColor.Undefined)
    {

    }
    public Car(string maker, string model) : this(maker, model, -1, CarColor.Undefined)
    {

    }
    public Car(string maker) : this(maker,string.Empty)
    {
    }
    public Car() : this(String.Empty)
    {

    }

    public override string ToString()
    {
        return $"{this.Maker}{(this.Model == string.Empty ? "" : ", ")}{this.Model}, {this.ProductionYear}, {this.CarColor}";
    }

    /*
    public static void PrintInfo(string maker, string model, int productionYear, CarColor color)
    {
        Console.WriteLine($"Maker: {maker}.");
        Console.WriteLine($"Model: {model}.");
        Console.WriteLine($"Production Year: {productionYear}.");
        Console.WriteLine($"Color: {color}.");
    }
    public static void PrintInfo(string maker, string model, int productionYear)
    {
        PrintInfo(maker, model, productionYear, CarColor.Undefined);
    }
    public static void PrintInfo(string maker, string model)
    {
        PrintInfo(maker, model, -1);
    }
    public static void PrintInfo(string maker)
    {

        PrintInfo(maker);
    }
    public static void PrintInfo()
    {
        PrintInfo(string.Empty);
    }
    */
}
