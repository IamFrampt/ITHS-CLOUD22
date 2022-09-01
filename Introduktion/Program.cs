/* //Game
Random random = new Random();
int rng = random.Next(1, 100);
int  win = 0;
int tries = 0;

Console.WriteLine("Hi! Guess what number I'm thinking of between 1-100");

while(win == 0)
    {
    var name = Console.ReadLine();
    int guess = Convert.ToInt32(name);

    if (guess > rng)
    {
        Console.Clear();
        Console.WriteLine("Too High, Guess again.");
        tries++;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Too Low, Guess again.");
        tries++;
    }

    if(guess == rng)
    {
        Console.Clear();
        Console.WriteLine("Correct!!, The number was: " + rng);
        Console.Write("It took you " + tries + " tries.");
        win++;

    }
}

*/

/*
Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();
Console.WriteLine($"Hej {name}, Trevligt att träffas.");
*/


for (int i = 9; i > 0; i--)
{
    Console.Write(i);
}
Console.WriteLine("");

Console.Write("What's your name: ");
string name = Console.ReadLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(name);
}