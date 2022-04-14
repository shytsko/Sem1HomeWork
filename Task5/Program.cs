// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

int outputNumber = 2;

while (outputNumber <= inputNumber)
{
    Console.Write(outputNumber);
    if (inputNumber - outputNumber > 1)
    {
        Console.Write(", ");
    }
    outputNumber += 2;
}
