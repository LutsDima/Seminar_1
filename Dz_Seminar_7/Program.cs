// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 Start();

 void Start()
 {
    while (true)
    {
        //Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет");
        Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Console.WriteLine(" 0 End");

        int numTask =  SetNumber("Введите номер задачи:");

        switch (numTask)
        {
            case 0 : return; break;
            case 47:
            PrintMatrix(GetRandomDoubleMatrix(4,4,0,100));
            break;
            case 50:
            int element = SetNumber("Введите элемент массива: ");
            //PrintMatrix()
            GetElementIndex(element,GetRandomMatrix(5,5,0,10));
            break;
            case 52:
            int[,] matrix = GetRandomMatrix(5,5,10,100);
            ColomsArithmeticMean(matrix);
            break;
            default: Console.WriteLine("error"); break;
        }


    } 
 }

 int SetNumber(string message)
 {
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
 }

 int[,] GetRandomMatrix(int rows, int colums, int minValue, int maxValue)
 {
    int [,] array = new int[rows, colums];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = rand.Next(minValue, maxValue);
        }
    }
    return array;
 }

 double[,] GetRandomDoubleMatrix(int rows, int colums, int minValue, int maxValue)
 {
    double [,] array = new double [rows, colums];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array [i,j] = Math.Round((rand.Next(minValue, maxValue) + rand.NextDouble()),2);
        }
    }
    return array;
 }

 void PrintMatrix(double [,] matrix)
 {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
 }

void GetElementIndex(int element, int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (element == array[i,j])
            {
                Console.WriteLine($"{i}, {j}");
                break;
            }
            else
            {
                Console.WriteLine($"Элемента {element} не существует в данной матрице");
                Console.ReadLine();
                break;
            }
            
        }
    }
}

void ColomsArithmeticMean(int [,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, j];
            }
        Console.Write($"{ sum / matrix.GetLength(0)} ");
    }
Console.ReadLine();
}