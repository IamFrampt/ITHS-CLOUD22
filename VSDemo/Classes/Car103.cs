using System.Runtime.InteropServices;

public class Car103
{
    public ConsoleColor CarColor;
    public int CarLength;
    public int Mph;
    private int maxDistance = 10000;
    public int Distance = 0;
    int trackLength = 90;
    int temp=1;
    int moveInXPos=0;

    public static Random random = new Random();

    private int carColor;
    private int carLength;

    public Car103()
    {
        this.Mph = random.Next(60, 241);
        carColor = random.Next(1, 16);
        carLength = random.Next(3, 6);

        this.CarColor = (ConsoleColor)carColor;
        this.CarLength = carLength;
    }
    public Car103(ConsoleColor carColor)
    {
        this.CarColor = (ConsoleColor)carColor;
        carLength = random.Next(3, 6);
        this.CarLength = carLength;
    }


    public static Car103[] GetCars(Car103 tenCars)
    {
        Car103[] cars = new Car103[10];

        for (int i = 0; i < cars.Length; i++)
        {
            int rnd = random.Next(3, 6);
            cars[i] = new Car103((ConsoleColor)tenCars.carColor);
        }

        return cars;
    }

    public void DriveForOneHour()
    {
        this.Distance += this.Mph;
        if(this.Distance > maxDistance)
            this.Distance = maxDistance;

    }
    public void GetGraph(int distance)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        string track = new string('-', this.trackLength);
        Console.WriteLine("|"+track+"|");
        

    }

    public void moveCar(int distance, ConsoleColor carColor, int row)
    {
        
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.SetCursorPosition(temp, row);
        Console.Write("-");
        int moveInXPos = Math.Min(distance / (maxDistance / this.trackLength), this.trackLength);
        if (moveInXPos < 1) moveInXPos = 1;
        //moveInXPos++;
        Console.SetCursorPosition(moveInXPos, row);
        Console.ForegroundColor = carColor;
        Console.WriteLine("X");
        temp = moveInXPos;
        //Thread.Sleep(1000-this.Mph);
    }
    public void PrintDistance(int distance, int row)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.SetCursorPosition(trackLength+2, row);
        Console.WriteLine(distance+"km");
    }

}