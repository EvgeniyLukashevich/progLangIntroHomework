// TASK 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, colums];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
            newArray[i, j] = rand.Next(minValue, maxValue + 1) + rand.NextDouble();
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = 5, n = 5, min = 0, max = 9;
double[,] array = CreateRandom2dArray(m,n,min,max);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Wow! So many digits after the point 0_0");
Console.ForegroundColor = ConsoleColor.Blue;
Show2dArray(array);
Console.ResetColor();
Console.WriteLine();
