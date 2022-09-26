// Övingar under lektionen

//Variabler

public class Box
{
    public int Width;
    public int Height;

    public int GetArea()
    {
        return Width * Height;
    }
    public int GetCircumference()
    {
        return Width * 2 + Height * 2;
    }

    public void PrintArea()
    {
        Console.WriteLine(GetArea().ToString());
    }
    public void PrintCircumference()
    {
        Console.WriteLine(GetCircumference().ToString());
    }



}
