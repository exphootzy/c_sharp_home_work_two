// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите трезначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 7)
{
    if (num == 1)
    Console.WriteLine("Нет. Понедельник - будний день!>");
    if (num == 2)
    Console.WriteLine("Нет. Вторник - будний день!>");
    if (num == 3)
    Console.WriteLine("Нет. Среда - будний день!>");
    if (num == 4)
    Console.WriteLine("Нет. Четверг - будний день!>");
    if (num == 5)
    Console.WriteLine("Нет. Пятница - будний день!>");
    if (num == 6)
    Console.WriteLine("Да. Суббота - выходной день!>");
    if (num == 7)
    Console.WriteLine("Да. Воскресенье - выходной день!>");
}

else
    Console.WriteLine("Введите число от 1 до 7, соответствующие дню недели!");
