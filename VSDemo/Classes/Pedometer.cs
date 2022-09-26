public class Pedometer
{
    public int step = 0;


    public int Step()
    {
        return this.step++;
    }
    public void ResetStep()
    {
        step = 0;
    }
    public void PrintStep()
    {
        Console.WriteLine($"You've walked {this.step} step{(this.step == 1 ? "" : "s")}.");
    }

}