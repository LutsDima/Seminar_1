// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

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
