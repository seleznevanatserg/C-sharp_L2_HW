//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//  6 -> да     7 -> да     1 -> нет

Console.WriteLine("Enter your number, please.");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (isParsed == true)
{
    if (number >= 1 & number <= 7)
    {
        if (number == 6 | number == 7)
        {
            Console.WriteLine("Yes. It's weekend");
        }
        else
        {
            Console.WriteLine("No. It's not weekend");
        }
    }
      
    else
    {
        Console.WriteLine("Sorry, it doesn't fit. Please, other number enter.");
    }

}
else
{
    Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
}


