// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5     782 -> 8    918 -> 1


Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine($"{number} -- it`s number from Random (100 - 999)");

int number2 = number / 10 % 10;
Console.WriteLine($"{number2} -- it`s 2th number from {number}");
