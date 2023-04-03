// Console.Clear();

// Console.WriteLine("Enter X and Y: ");
// int numberX = int.Parse(Console.ReadLine());
// int numberY = int.Parse(Console.ReadLine());

// if (numberX > 0 && numberY > 0)
// {
//     Console.WriteLine("Квадрант № 1");
// } 
// else if (numberX > 0 && numberY < 0)
// {
//     Console.WriteLine("Квадрант № 2");
// }
// else if (numberX < 0 && numberY < 0)
// {
//     Console.WriteLine("Квадрант № 3");
// }
// else if (numberX < 0 && numberY > 0)
// {
//     Console.WriteLine("Квадрант № 4");
// }

// Console.Clear();

// Console.WriteLine("Введите номер квадранта: ");
// int num = int.Parse(Console.ReadLine());

// if (num ==1)
// {
//     Console.WriteLine("X>0; Y>0");
// }
// else if (num == 2)
// {
//     Console.WriteLine("X<0; Y>0");
// }
// else if (num == 3)
// {
//     Console.WriteLine("X<0; Y<0");
// }
// else if (num == 4)
// {
//     Console.WriteLine("X>0; Y<0");
// }

// Console.WriteLine("Введите сумму вклада: ");
// double cash = Convert.ToDouble(Console.ReadLine());

// if (cash < 100)
// {
//     cash = cash + cash * 0.05;
//     Console.WriteLine($"вклад равен {cash}");
// }
// else if (cash > 100 && cash < 200)
// {
//     cash = cash + cash * 0.07;
//     Console.WriteLine($"вклад равен {cash}");
// }
// else if (cash > 200)
// {
//     cash = cash + cash * 0.1;
//     Console.WriteLine($"вклад равен {cash}");
// }

// Console.Clear();
// Console.WriteLine("Введите координаты первой точки :");
// Console.Write("X: ");
// double numX1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Y: ");
// double numY1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки :");
// Console.Write("X: ");
// double numX2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Y: ");
// double numY2 = Convert.ToDouble(Console.ReadLine());

// double sum = Math.Sqrt(Math.Pow((numX2-numX1),2) + Math.Pow((numY2-numY1),2));

// Console.WriteLine($"Координаты точки = {sum}");

// // double sum = Math.Pow(12,2);
// // Console.WriteLine($"{sum}");

Console.Clear();

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int i = 1;
while (i <= num)
{
    Console.Write($"{i*i} ");
    i++;
}
Console.WriteLine();