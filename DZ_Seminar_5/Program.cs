// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int [] GetArray(int sizeArray, int minValue, int maxValue)
{
    int [] resultArray = new int[sizeArray];
    Random rand = new Random();

    for(int i = 0; i < sizeArray; i++)
    {
        resultArray[i] = rand.Next(minValue, maxValue + 1);
    }

    return resultArray;
}

int GetNumberEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}
int [] Array = GetArray(10, 100, 999);
int NumberEvent = GetNumberEven(Array);
Console.WriteLine(string.Join(", ",Array));
Console.WriteLine($"Количество четных чисел в массиве = {NumberEvent}");

Console.ReadKey();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int [] GetArray2 (int sizeArray, int minValue, int maxValue)
{
    Random rand = new Random();
    int [] array = new int [sizeArray];
    for(int i = 0; i < sizeArray; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    } 
    return array;
} 

int GetSumNumber (int [] array)
{
    int sumNumber = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i%2 !=0)
        {
            sumNumber = sumNumber + array[i];
        }
    }

    return sumNumber;
}

int[] Array2 = GetArray2(6, 1, 10);
int resultSum = GetSumNumber(Array2);
Console.WriteLine(string.Join(", ", Array2));
Console.WriteLine($"Ссумма элементов, стоящих на нечётных позициях = {resultSum}");

Console.ReadKey();

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] GetArray3 (int sizeArray, int minValue, int maxValue)
{
    int[] array = new int [sizeArray];
    Random rand = new Random();
    for(int i = 0; i < sizeArray; i++)
    {
        array[i] = rand.Next(minValue, maxValue);
    }
    return array;
}

int GetSub (int[] array)
{
    int max = array[0];
    int min = array[0];
    int sub = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }

    sub = max - min;
    }
    return sub;
}

int[] Array3 = GetArray3(10,10,100);
Console.WriteLine(string.Join(", ", Array3));
int sub = GetSub(Array3);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {sub}");