// TASK 1. Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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

int[,] ArrangeRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int lap = 0; lap < array.GetLength(1) - 1; lap++)    // lap - что-то вроде счетчика кругов, пройденных по строке
            for (int j = 0; j < array.GetLength(1) - 1 - lap; j++)
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                }
    
    return array;
}

int rows = 5, columns = 5, min = 0, max = 9;
int[,] array = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(array);
Show2dArray(ArrangeRows(array));
