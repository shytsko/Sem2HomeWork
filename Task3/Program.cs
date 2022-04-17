// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите номер дня недели: ");
int inputNumberDay = Convert.ToInt32(Console.ReadLine());

if (IsDayOff(inputNumberDay))
    Console.WriteLine("Выходной день!");
else if (IsDayWorking(inputNumberDay))
    Console.WriteLine("Рабочий день.");
else
    Console.WriteLine("Такого дня недели не существует.");

bool IsDayOff(int numberDay)
{
    return numberDay == 6 || numberDay == 7;
}

bool IsDayWorking(int numberDay)
{
    return numberDay >= 1 && numberDay <= 5;
}