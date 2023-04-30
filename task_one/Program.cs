// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трезначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int init = num;
int count = 0;

while (init > 0)
{
init = init / 10;
count++;
}

if (count == 3)
{
    num = num / 10;
    num = num % 10;
    Console.WriteLine($"Второе число: {num}");
}

else 
{
    Console.WriteLine("Введите трехзначное число!");  
}
