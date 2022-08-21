// Task 5. Заполните спирально массив 4 на 4.

int[,] MatrixSpiralFill(int size) 
{
    int[,] result = new int[size, size];
 
    int pos = 0;
    int count = size;
    int value = -size;
    int sum = -1;
 
    while (count > 0)
    {
        value = -1 * value / size;
        
        for (int i = 0; i < count; i++) 
        {
            sum += value;
            result[sum / size, sum % size] = pos++;
        }
    
        value *= size;
        count--;
    
        for (int i = 0; i < count; i++) 
        {
            sum += value;
            result[sum / size, sum % size] = pos++;
        }
    }
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

Show2dArray(MatrixSpiralFill(10));