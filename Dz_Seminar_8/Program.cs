// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Start();

void Start()
 {
    while (true)
    {
        //Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        Console.WriteLine("Задача 60:Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        Console.WriteLine("Задача 62: Напишите программу, которая заполнит спирально массив . Размер вводит юзер");
        Console.WriteLine("End: 0");

        int numTask =  SetNumber("Введите номер задачи:");

        switch (numTask)
        {
            case 0 : return; break;

            case 54:
            int [,] matrix = GetMatrix(4,4, 0,10);
            PrintMatrix(matrix);
            Console.WriteLine();
            PrintMatrix(SortMatrix(matrix));
            Console.ReadKey();
            break;

            case 56:
            matrix = GetMatrix(4,4,0,10);
            PrintMatrix(matrix);
            Console.WriteLine($"{GetMinSumRow(matrix)}");
            Console.ReadKey();
            break;

            case 58:
            int[,] matrix1 = GetMatrix(4,4,0,10);
            int[,] matrix2 = GetMatrix(4,4,0,10);
            PrintMatrix(matrix1);
            Console.WriteLine();
            PrintMatrix(matrix2);
            Console.WriteLine();
            PrintMatrix(MultMatrix(matrix1,matrix2));
            Console.ReadKey();
            break;

            case 60:

            break;

            case 62;

            break;

            default: Console.WriteLine("error"); break;
        }


    } 
 }

int SetNumber(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetMatrix (int rows, int columns, int minValue, int maxValue)
{
    var random = new Random();
    int [,] matrix = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = random.Next(minValue,maxValue);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-j-1; k++)
            {
                if (matrix[i,k] < matrix[i,k+1])
            {
                int temp = matrix[i,k]; 
                matrix[i,k] = matrix[i,k+1];
                matrix[i,k+1] = temp;
            }
            }
        }
    }
    return matrix;
}

int GetMinSumRow(int[,] matrix)
{
    int min = 0;
    int[] sum = new int[matrix.GetLength(0)]; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum [i] += matrix[i,j];
        }   
    }

    for (int i = 0; i < sum.Length; i++)
    {
        if(sum[i]< sum[min])
        {
            min = i+1;
        }
    }
    return min;
}

int[,] MultMatrix (int[,]matrix1, int[,]matrix2)
{
    int[,] multMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                temp += matrix1[i,k] * matrix2[k,j];
            }
            multMatrix[i,j] = temp;
        }
    }
    return multMatrix;
}
// int[,] matrix1 = GetMatrix(2,2,1,4);
// int[,] matrix2 = GetMatrix(2,2,1,4);
// PrintMatrix(matrix1);
// Console.WriteLine();
// PrintMatrix(matrix2);
// Console.WriteLine();
// //int[,] sortMatrix = SortMatrix(matrix);
// //int minSumRow = GetMinSumRow(matrix);
// int[,] resultMatrix = MultMatrix(matrix1, matrix2);
// PrintMatrix(resultMatrix);
// //Console.WriteLine($"Строка с минимальной суммой >> {minSumRow}");