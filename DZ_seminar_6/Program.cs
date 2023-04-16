// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Clear();

// int[] GetArray (string Namber)
// {
//     int [] array = Namber.Split(' ').Select(x => int.Parse(x)).ToArray();
//     return array;
// }

// int  PolNumber(int [] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine("Введите несколько чисел: ");
// int [] num = GetArray(Console.ReadLine());
// int count = PolNumber(num);
// Console.WriteLine($"-> {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//x=(b2-b1)/(k1-k2);  y=(k1*(b2-b1))/(k1-k2)+b1

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int Line1 = 1;
const int Line2 = 2;
const int X_Coord = 0;
const int Y_Coord = 1;

double[] LineDate1 = InputLineDate(Line1);
double[] LineDate2 = InputLineDate(Line2);

if (ValidDate(LineDate1, LineDate2))
{
    double[] coord = FindCoord(LineDate1, LineDate2);
    Console.WriteLine($"{coord[X_Coord]}, {coord[Y_Coord]}");
}

double Prompt(string message)
{
    Console.WriteLine(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

double [] InputLineDate(int NumberOfLine)
{
    double [] LineDate = new double [2];
    LineDate[COEFFICIENT] = Prompt($"Введите коэффициент для {NumberOfLine} линии > ");
    LineDate[CONSTANT] = Prompt($"Введите константу для {NumberOfLine} линии > ");
    return LineDate;
}

double [] FindCoord(double [] LineDate1, double [] LineDate2)
{
    double [] coord = new double[2];
    coord[X_Coord] = (LineDate2[COEFFICIENT] - LineDate1[COEFFICIENT])/(LineDate1[CONSTANT]- LineDate2[CONSTANT]);
    coord[Y_Coord] = LineDate1[CONSTANT]*coord[X_Coord]+ LineDate1[COEFFICIENT];
    return coord;
}

bool ValidDate( double[] LineDate1, double[] LineDate2)
{
    if (LineDate1[COEFFICIENT] == LineDate2[COEFFICIENT])
    {
        if (LineDate1[CONSTANT] == LineDate2[CONSTANT])
        {
            Console.WriteLine("Прямые Совпадают");
            return false;
        }
        else {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}


