﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
bool palindrome (int Number)
{
    if (Number / 10000 == Number % 10 && Number % 100 / 10 == Number / 1000 % 10)
    {
        return true;
    }
    return false;
}

bool validNumber (int numb)
{
    if (numb < 100000 && numb > 9999)
    {
        return true;
    }
    Console.WriteLine("Это не пятизначное число");
    return false;
}

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (validNumber(num))
{
    if (palindrome(num))
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом");
    }
}

Console.ReadKey();

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1: ");
double numX1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1: ");
double numY1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z1: ");
double numZ1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2: ");
double numX2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2: ");
double numY2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z2: ");
double numZ2 = Convert.ToDouble(Console.ReadLine());

double sum = Math.Sqrt(Math.Pow((numX2-numX1),2) + Math.Pow((numY2-numY1),2) + Math.Pow((numZ2-numZ1),2));

Console.WriteLine($"{sum}");
Console.ReadKey();

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите число :");
num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write($"{i*i*i}, ");
}

Console.ReadKey();