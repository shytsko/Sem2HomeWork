// Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает.
// Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
// Доп. задача с усложнением: на отгадывание дается 3 попытки.

int inputMysteryNumber = new Random().Next(100);

Console.WriteLine($"Загадоное число: {inputMysteryNumber}");

Console.WriteLine("Отгадайте загадонное число от 0 до 99");

int countTries = 3;
while (countTries > 0)
{
    Console.WriteLine();
    Console.WriteLine($"Осталось попыток: {countTries}");
    Console.Write("Введите число: ");
    int inputUsersNumber = Convert.ToInt32(Console.ReadLine());
    if (inputUsersNumber == inputMysteryNumber)
        break;
    else
    {
        Console.Write("Не угадали. Ваше число ");
        if (inputUsersNumber > inputMysteryNumber)
            Console.Write("больше ");
        else
            Console.Write("меньше ");
        Console.WriteLine("загадонного");
    }
    countTries--;
}

if (countTries > 0)
    Console.WriteLine("Поздравляем!!! Вы угадали число!!!");
else
    Console.WriteLine("Увы. Больше попыток нет");

