// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.WriteLine("Введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine());

// int num1 = (num % 100) / 10;

// Console.WriteLine($"{num1}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1: Console.WriteLine("NO"); break;
    case 2: Console.WriteLine("NO"); break;
    case 3: Console.WriteLine("NO"); break;
    case 4: Console.WriteLine("NO"); break;
    case 5: Console.WriteLine("NO"); break;
    case 6: Console.WriteLine("Yes"); break;
    case 7: Console.WriteLine("Yes"); break;
}