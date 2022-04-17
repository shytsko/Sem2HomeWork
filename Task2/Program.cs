// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int[] inputNumbers = { 645, 78, 32679, new Random().Next(), new Random().Next(1000000), new Random().Next(10000), new Random().Next(100) };

int index = 0;
while (index < inputNumbers.Length)
{
    Console.Write($"Исходное число {inputNumbers[index]} -> ");
    int thirdDigit = GetThirdDigit(inputNumbers[index]);
    if (thirdDigit == -1)
        Console.WriteLine("третьей цифры нет");
    else
        Console.WriteLine($"третья цифра: {thirdDigit}");
    index++;
}


int GetThirdDigit(int number)
{
    if (number < 100)
        return -1;

    while (number > 999)
        number /= 10;

    return number % 10;
}