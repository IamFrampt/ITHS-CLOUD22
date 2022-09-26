// INFORMATION

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine(Console.WindowWidth);
Console.WriteLine(Console.WindowHeight);



//CHANGE COLOR UNTIL SAME AS FIRST LETTER

string input = Console.ReadLine();
bool doColor;
doColor = true;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == input[0])
    {
        if (doColor)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(input[i]);
        }
        else
        {
            Console.Write(input[i]);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        doColor = !doColor;
    }
    else Console.Write(input[i]);
}