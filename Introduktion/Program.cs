//Console.WriteLine("Vad heter du?");
//string name = Console.ReadLine();
//Console.WriteLine($"Hej {name}, Trevligt att träffas.");


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


int x = 5;
int y = (x < 3 ? 0 : 1);
Console.WriteLine(x);
Console.WriteLine(y);


//Ternery Operator

for (int i = 0; i < 20; i++)
{
    //if(i %2==0)
    //Console.Write("x");
    //else
    //Console.Write("o");
    Console.WriteLine(i % 2 == 0 ? "X" : "O");
}

var users = 2;

Console.WriteLine($"There are {users} user{(users == 1 ? "" : "s")}.");
