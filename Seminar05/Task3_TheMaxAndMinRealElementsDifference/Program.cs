// TASK 3. The max and min real elements difference

void ShowArray(double[] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Catch your array: ");
    
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("| ");

    for (int index = 0; index < array.Length; index++)
        Console.Write($"{array[index]} | ");

    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();
}

double[] CreateUserArray()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Input size of created array: ");
    Console.ResetColor();
    int size = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"Input the {i+1} real number of {size}: ");
        Console.ResetColor();
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}

void MaxMinDiff(double[] array)
{
    double max = array[0], min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];

        if (array[i] < min) min = array[i];
    }
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"The MAX element in this array is {max}");
    Console.WriteLine($"The MIN element in this array is {min}");
    Console.WriteLine($"The difference between {max} and {min} is {max - min}");
    Console.ResetColor();
    Console.WriteLine();
}

double MaxMinDiff2(double[] array)
{
    double diff, max = array[0], min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];

        if (array[i] < min) min = array[i];
    }
    
    diff = max - min;
    return diff;
} 

double[] array = CreateUserArray();
ShowArray(array);
MaxMinDiff(array);
