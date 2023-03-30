// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
int Number_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number_b = Convert.ToInt32(Console.ReadLine());

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

Console.ReadKey();


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
double Number_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double Number_2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите третье число: ");
double Number_3 = Convert.ToDouble(Console.ReadLine()); 
double Number_max = Number_a;

if (Number_1 > Number_2)
{
    Number_max = Number_1;
}
else if (Number_2 > Number_3)
{
    Number_max = Number_2;
}
else Number_max = Number_3;

Console.WriteLine($"Максимальное число = {Number_max}");

Console.ReadKey();

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число: ");
int Number_one = Convert.ToInt32(Console.ReadLine());

if (Number_one%2 == 0 )
{
    Console.WriteLine($"Число {Number_one} четное.");
}
else 
{
    Console.WriteLine($"Число {Number_one} нечетное.");
}

Console.ReadKey();

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int One_number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (count < One_number)
{
    count++;
    if (count%2 == 0)
    {
        Console.WriteLine(count);
    }
}

Console.ReadKey();
