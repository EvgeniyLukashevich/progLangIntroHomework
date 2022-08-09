// Попробовал написать метод для дополнительной задачи с семинара.
// Работает с четным размером массива и с нечетным, учитывая центральный элемент.

int[] ProdPairsOfElements(int[] array)
{
    int[] newArray = new int[(array.Length + 1) / 2];       // Проблему с центральным элементом решил в этой строке, 
                                                            // добавив единицу к размеру, перед делением пополам. 
    for (int i = 0; i < array.Length / 2; i++)
        newArray[i] = array[i] * array[array.Length-(i + 1)];
    
    if (array.Length % 2 != 0)
        newArray[array.Length / 2] = array[array.Length / 2];
    
    return newArray;
}


// TASK 1. Even three-digit positive numbers in a random array
/*
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
*/


// TASK 2. The sum of the elements in odd positions
/*
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
*/



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
                                        // Мне показалось удобнее здесь применить войдовский метод,
double MaxMinDiff2(double[] array)      // но, на всякий случай, сделал еще метод возвращающий разницу 
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
