// Task 2. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

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

int[] RowsSumArray(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            newArray[i] += array[i, j];

    return newArray;
}

int rows = 5, columns = 4, min = 0, max = 9;
int[,] array = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(array);

int[] sumArray = RowsSumArray(array);
int minSum = sumArray[0];
int minRow = 1;

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine($"The sum of the {i + 1} row elements is {sumArray[i]}");

    if (sumArray[i] < minSum)
    {
        minSum = sumArray[i];
        minRow = i + 1;
    }
}

Console.WriteLine();
Console.WriteLine($"The {minRow} row is the row with the smallest sum of elements");
