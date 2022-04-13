// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int inputNumber = new Random().Next(100, 1000);
int outputNumber = inputNumber % 10;

Console.WriteLine("Входное число: " + inputNumber);
Console.WriteLine("Последняя цифра входного числа: " + outputNumber);
