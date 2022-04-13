// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Первое число (" + numberA + ") больше второго числа (" + numberB + ")");
}
else if (numberA < numberB)
{
    Console.WriteLine("Второе число (" + numberB + ") больше первого числа (" + numberA + ")");
}
else
{
    Console.WriteLine("Первое число (" + numberA + ") и второе число (" + numberB + ") равны");
}