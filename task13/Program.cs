// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5     78 -> третьей цифры нет     32679 -> 6

Console.WriteLine("Enter your number, please.");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);


if (isParsed == true)
{
    if (number >= 100 | number <= -100)
    {   
        int number3 = number;
        if (number3 < 0)
        {
            number3 = number3 * -1;
        }
        
        if (number3 > 999)
        {
            while (number3 > 999)
            {
                number3 = number3 / 10;
            }
            number3 = number3 % 10;
        }
        
        else
        {   
            number3 = number3 % 10;
        }
        
        Console.WriteLine($"{number3} -- it`s 3th number from {number}");
    }
    else
    {
        Console.WriteLine($"Sorry, have not 3th number from {number}.");
    }
}
else
{
    Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
}


