// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int inputNumber = new Random().Next(100, 1000);

int digit2 = GetDigit2(inputNumber);

Console.WriteLine($"Вторая цифра числа {inputNumber}: {digit2}");

int GetDigit2(int input)
{
    return input / 10 % 10;
}
