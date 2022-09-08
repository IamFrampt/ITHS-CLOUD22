
int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

for (int i = 0; i < number.Length; i++)
    Console.Write($"{i} ");

Console.WriteLine();

foreach (int i in number)
    Console.Write($"{i * 2} ");
