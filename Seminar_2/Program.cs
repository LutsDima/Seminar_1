﻿// int Number  = new Random().Next(1,100);

// Console.WriteLine($"{Number}");
// int num1 = Number / 10;
// int num2 = Number % 10;

// Console.WriteLine($"{num1} {num2}");



// Console.Clear();

// int num = new Random().Next(100, 1000);

// Console.WriteLine($"{num}");
// int num1 = num / 100;
// int num2 = (num % 10); 

// Console.WriteLine($"{num1}{num2}");

Console.Clear();

Console.WriteLine("Введите 2 числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine($"{num1} кратно {num2}");
} 
else
{
    Console.WriteLine($"{num1 % num2}");
}
