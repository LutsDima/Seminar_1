// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
double Number_a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double Number_b = Convert.ToDouble(Console.ReadLine());

if (Number_a > Number_b)
{
    Console.WriteLine($"max = {Number_a} ");
}
else if (Number_a < Number_b)
{
    Console.WriteLine($"max = {Number_b} ");
}
else 
{
    Console.WriteLine("Числа равны");
}