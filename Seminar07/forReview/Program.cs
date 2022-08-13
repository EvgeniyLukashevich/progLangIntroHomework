// TASK 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
/*
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
Console.WriteLine("Wow! So many digits after the point 0_0");
Show2dArray(array);
Console.WriteLine();
*/


// TASK 2. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

string ElementSearch(int[,] array, int i, int j)
{
    string result = "";

    if (i < array.GetLength(0) && j < array.GetLength(1))
        result = $"{array[i, j]}";
    else result = "no number";

    return result;
}

void Show2dArray(int[,] array)
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
string result = "";

Console.Write("Input the row of the element you are looking for: ");
int i = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input the column of the element you are looking for: ");
int j = Convert.ToInt32(Console.ReadLine()) - 1;

int[,] array = CreateRandom2dArray(m, n, min, max);
result = ElementSearch(array, i, j);

Console.WriteLine();
Show2dArray(array);
Console.WriteLine($"There is {result} at this position");
Console.WriteLine();
*/


/*
// TASK 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце

// Уверен, что задача решается проще. Обязательно придумаю такое решение,
// но пока не могу выделить на это время

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void Show2dArray(int[,] array)
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

double[] MeanOfTheColimn(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    int sum = 0, i = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        while (i < array.GetLength(0))
        {
            sum += array[i, j];
            i++;
        }

        newArray[j] = Convert.ToDouble(sum) / Convert.ToDouble(i);
        i = 0;
        sum = 0;
    }

    return newArray;
}

int m = 5, n = 5, min = 0, max = 9;
int[,] array = CreateRandom2dArray(m, n, min, max);

Show2dArray(array);

double[] newArray = MeanOfTheColimn(array);

for (int i = 0; i < newArray.Length; i++)
    Console.WriteLine($"Arithmetic mean of the {i + 1} column is {newArray[i]}");

*/

