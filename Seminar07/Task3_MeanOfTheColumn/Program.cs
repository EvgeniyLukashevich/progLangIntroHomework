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


