
Start();

void Start()
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("Задача 64: Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        //N = 5 -> "5, 4, 3, 2, 1"
        //N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
        Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
       // M = 1; N = 15 -> 120
        //M = 4; N = 8. -> 30
        Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        //m = 2, n = 3 -> A(m,n) = 9
        //m = 3, n = 2 -> A(m,n) = 29

        int numTask = SetNum("Введите номер задачи: ");

        switch (numTask)
        {
            case 0 : return; break;

            case 64 : 

            int startNumber = SetNum("Введите начальное значение: ");
            int endNumber = SetNum("Введите конечное значение: ");
            GetNaturalNumber(startNumber, endNumber);

            break;

            case 66 : 
            startNumber = SetNum("Введите начальное значение: ");
            endNumber = SetNum("Введите конечное значение: ");
            int sum = GetSumNaturalElement(startNumber, endNumber);
            Console.WriteLine($"Сумма натуральных элементов = {sum}");


            break;

            case 68 :
            startNumber = SetNum("Введите значение n: ");
            endNumber = SetNum("Введите значение m: ");
            int result = GetAkkerman(startNumber, endNumber);
            Console.WriteLine($"Значение функции = {result}");
            break;

            default : Console.WriteLine("Error"); break;

        }

    }
}

int SetNum (string message)
    {
        Console.WriteLine(message);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
    }

void GetNaturalNumber (int startNumber,int endNumber)
    {
        if(startNumber==endNumber)
            {
                Console.Write($" {endNumber}, ");
            }
            else
            {
                GetNaturalNumber(startNumber + 1,endNumber);
                Console.Write($"{startNumber}, ");
            }
    }    

int GetSumNaturalElement(int startNumber, int endNumber)
{
    int sum = 0;
    while (startNumber <= endNumber)
    {
        sum += startNumber;
        GetSumNaturalElement(startNumber + 1, endNumber);
        startNumber++;
    }
    return sum;
}

int GetAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if((m > 0) && (n == 0))
    {
        return GetAkkerman(m - 1, 1);
    }
    else if((m > 0) && (n > 0))
    {
        return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
    }
    else
        return n + 1;
}
 