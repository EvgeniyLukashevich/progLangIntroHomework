// TASK 1. Even three-digit positive numbers in a random array


int[] CreateUserSize3DigElArray()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Please, input size of the created array: ");
    Console.ResetColor();
    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    int minValue = 100;
    int maxValue = 999;

    int[] array = new int[size];

    for (int index = 0; index < size; index++)
        array[index] = new Random().Next(minValue, maxValue +1);

    return array;
}

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

void EvenShow(int[] array)
{
    int count = 0;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Even array elements:");

    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] % 2 == 0)
        {
            count++;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{array[i]} ");
        }
    }

    if (count == 0)
    {        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Sorry. There are no even elements in this array.");    
    }

    Console.ResetColor();
    Console.WriteLine();
}

int[] array = CreateUserSize3DigElArray();
ShowArray(array);
EvenShow(array);



