// TASK 2. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет

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
