// TASK 2. The sum of the elements in odd positions

void ShowArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Catch your array: ");

    Console.ForegroundColor = ConsoleColor.Blue;
    
    for (int index = 0; index < array.Length; index++)
        Console.Write($"{array[index]} ");

    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();
}

int[] CreateUserSizeRandomElArray()
{
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Please, input the size of an array: ");
    Console.ResetColor();
    int size = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Please, input the MIN possible value of an element: ");
    Console.ResetColor();
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Please, input the MAX possible value of an element: ");
    Console.ResetColor();
    int maxValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    int[] array = new int[size];

    for (int index = 0; index < size; index++)
        array[index] = new Random().Next(minValue, maxValue +1);

    return array;
}

int SumOfOddPosElements(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i += 2)
        sum += array[i];
    
    return sum;
}

int[] array = CreateUserSizeRandomElArray();
ShowArray(array);
int sum = SumOfOddPosElements(array);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Sum of odd positions elements is {sum}");
Console.ResetColor();
Console.WriteLine();