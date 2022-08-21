// Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Ну это жесть, конечно :))

int[,,] Create3dArray(int rows, int columns, int depth, int min, int max)
{
    int[,,] array = new int[rows, columns, depth];
    int count = 0, randomNum;                           // Добавил счетчик, увеличивающийся, если нет совпадений со сгенерированным рандомно числом
                                                        // Также добавил перемменную, которой присваивается рандомное число. Если после проверки на повторения
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

