﻿// Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Число " + inputNumber);

if(inputNumber % 2 == 0)
{
    Console.WriteLine(" четное");
}
else
{
    Console.WriteLine(" нечетное");
}