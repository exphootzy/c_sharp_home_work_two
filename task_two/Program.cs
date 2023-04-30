// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите любое число");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;
int remainder = inputNumber;
int divider = 10;
int answer = 0;

if (inputNumber < 0)
{
    inputNumber = inputNumber * -1;
    remainder = remainder * -1;
}

while (remainder > 0)
{
    remainder = remainder / divider;
    count++;
}

if (count == 1)
{
    Console.WriteLine("Нет третьего числа слева");
    return;
}

if (count == 2)
{
    Console.WriteLine("Нет третьего числа слева");
    return;
}

if (count == 3)
{
    answer = inputNumber % 10;
    Console.WriteLine($"Третье число слева: {answer}");
    return;
}

count = count - 4;

while (count > 0)
{
    divider = divider * 10;
    count--;
}

answer = inputNumber / divider;

answer = answer % 10;

Console.WriteLine($"Третье число слева: {answer}");