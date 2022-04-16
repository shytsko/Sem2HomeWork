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


int GetLenIntegerNumber(int number)
{
    if (number == 0)
        return 1;

    int countDigits = 0;
    while (number > 0)
    {
        number /= 10;
        countDigits++;
    }

    return countDigits;
}


int GetThirdDigit(int number)
{
    int inputNumberLen = GetLenIntegerNumber(number);

    if (inputNumberLen < 3)
        return -1;

    int countDiv = inputNumberLen - 3;
    while (countDiv > 0)
    {
        number /= 10;
        countDiv--;
    }

    return number % 10;
}