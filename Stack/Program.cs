Stack<string> names = new Stack<string>();

string userInput = string.Empty;
do
{
    userInput = Console.ReadLine();
    names.Push(userInput);

} while (userInput != string.Empty);

while (names.Count > 0)
{
    Console.WriteLine(names.Pop());

}

//names.Push("Mikael");
//names.Push("Paulina");
//names.Push("Ioannis");
//names.Push("Pontus");
