bool isValid = false;

do
{
    try
    {
        Console.Write("Skriv in ett tal: ");
        int input = Int32.Parse(Console.ReadLine());
        Console.WriteLine(input * 10);
        isValid = true;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message + "Try again.");
    }

} while (!isValid);
