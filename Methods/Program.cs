////PrintGreetingMultipleTimes("Mikael", 5, true);
////Console.WriteLine();
////PrintGreetingMultipleTimes("Paulina", 1, false);

//void PrintGreetingMultipleTimes(string name, int number, bool printExclamationMark)
//{
//    for (int i = 1; i <= number; i++)
//        if (printExclamationMark)
//            Console.WriteLine($"Hello, {name}!!!");
//        else
//            Console.WriteLine($"Hello, {name}");
//}

////int result = AddFive(7);
////Console.WriteLine(result);

//int AddFive(int number)
//{
//    return number + 5;
//}
////_______________________________________________________________________________

//int[] myNumbers = { 1, 3, 8, 2 };
//int result = Sum(myNumbers);
////Console.WriteLine(result);


//int Sum(int[] numbers)
//{
//    int sum = 0;
//    foreach (int number in numbers)
//        sum += number;
//    return sum;
//}

//int result2 = Sum2(1, 3, 8, 2);
////Console.WriteLine(result);


//int Sum2(params int[] numbers)
//{
//    int sum = 0;
//    foreach (int number in numbers)
//        sum += number;
//    return sum;
//}

MethodA();
MethodB();
MethodA();

void MethodA()
{
    Console.WriteLine("MethodA");
    MethodB();
    MethodC();
}
void MethodB()
{
    Console.WriteLine("MethodB");
}
void MethodC()
{
    Console.WriteLine("MethodC");
}