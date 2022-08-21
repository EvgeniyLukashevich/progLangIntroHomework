// TASK 1. Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
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
*/


// Task 2. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
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
*/


// Task 3. Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
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
*/


// Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Ну это жесть, конечно :))

int[,,] Create3dArray(int rows, int columns, int depth, int min, int max)
{
    int[,,] array = new int[rows, columns, depth];
    int count = 0, randomNum;                           // Добавил счетчик, увеличивающийся, если нет совпадений со сгенерированным рандомно числом
                                                        // Также добавил переменную, которой присваивается рандомное число. Если после проверки на повторения
    for (int i = 0; i < rows; i++)                      // оказывается, что равного ей элемента нет, то её значение присваивается текущему элементу.
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
                randomNum = new Random().Next(min, max + 1);

                for (int ii = 0; ii < rows; ii++)
                    for (int jj = 0; jj < columns; jj++)
                        for (int kk = 0; kk < depth; kk++)
                        {
                            if (randomNum != array[ii, jj, kk])
                                count++;
                        }

                if (count == rows * columns * depth)
                    array[i, j, k] = randomNum;

                else
                {
                    count = 0;
                    k -= 1;
                    continue;
                }
            }

    return array;
}

void Show3dArray(int[,,] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");

        Console.WriteLine();
        Console.WriteLine();
    }
}

int rows = 5, columns = 3, depth = 3, min = 10, max = 99;

if (max - min < rows * columns * depth)
{
    Console.WriteLine();
    Console.WriteLine("The range of possible values (max - min) must be equal or greater than number of array elements (rows * columns * depth)");
    Console.WriteLine();
}
else Show3dArray(Create3dArray(rows, columns, depth, min, max));

