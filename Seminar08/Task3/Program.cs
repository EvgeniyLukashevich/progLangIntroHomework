// Task 3. Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int[,] MatricesProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
            matrixResult[i, j] = matrix1[i, j] * matrix2[i, j];
    }
    return matrixResult;
}

int rows1 = 3, columns1 = 3, min1 = 0, max1 = 9;
int[,] firstMatrix = CreateRandom2dArray(rows1, columns1, min1, max1);
Console.WriteLine("The 1st matrix is:");
Show2dArray(firstMatrix);

int rows2 = 3, columns2 = 3, min2 = 0, max2 = 9;
int[,] secondMatrix = CreateRandom2dArray(rows2, columns2, min2, max2);
Console.WriteLine("The 2nd matrix is:");
Show2dArray(secondMatrix);

if (rows1 == rows2 && columns1 == columns2)
{
    Console.WriteLine("The product of 1st and 2nd matrices is:");
    Show2dArray(MatricesProduct(firstMatrix, secondMatrix));
}
else Console.WriteLine("The sizes of the matrices should be the same");


