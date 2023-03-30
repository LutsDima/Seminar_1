// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Clear();
// Console.Write("Введите первое число: ");
// double Number_a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double Number_b = Convert.ToDouble(Console.ReadLine());

// if (Number_a > Number_b)
// {
//     Console.WriteLine($"max = {Number_a} ");
// }
// else if (Number_a < Number_b)
// {
//     Console.WriteLine($"max = {Number_b} ");
// }
// else 
// {
//     Console.WriteLine("Числа равны");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Clear();
// Console.Write("Введите первое число: ");
// double Number_a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double Number_b = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Введите третье число: ");
// double Number_c = Convert.ToDouble(Console.ReadLine()); 
// double Number_max = Number_a;

// if (Number_a > Number_b)
// {
//     Number_max = Number_a;
// }
// else if (Number_b > Number_c)
// {
//     Number_max = Number_b;
// }
// else Number_max = Number_c;

// Console.WriteLine($"Максимальное число = {Number_max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число: ");
int Number_a = Convert.ToInt32(Console.ReadLine());

if (Number_a%2 == 0 )
{
    Console.WriteLine($"Число {Number_a} четное.");
}
else 
{
    Console.WriteLine($"Число {Number_a} нечетное.");
}

