// TASK 3. An array of eight elements

void ShowArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    
    for (int index = 0; index < array.Length; index++)
        Console.Write($"{array[index]} ");

    Console.ResetColor();
    Console.WriteLine();
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int index = 0; index < size; index++)
        array[index] = new Random().Next(minValue, maxValue +1);

    return array;
}

int size = 8, minValue, maxValue;
int[] userArray = new int[size];

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Would you like to fill in the array yourself? (Yes / No): ");
Console.ForegroundColor = ConsoleColor.White;
string usersDecision = Console.ReadLine();
Console.ResetColor();


for (int count = 0; usersDecision != "Yes" && usersDecision != "No" && count < 3; count++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Just tell me, do you want to fill in this array yourself?");
        Console.Write($"You have {3-count} lives left. Yes or No: ");
        Console.ResetColor();
        usersDecision = Console.ReadLine();
    }

if (usersDecision == "Yes")
{
    for (int i = 0; i < size; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"Input the {i+1} integer: ");
        Console.ResetColor();
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Catch your array:");
    ShowArray(userArray);

}

if (usersDecision == "No")
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Okey, I'll do it for you :)");
    Console.Write("Just tell me the minimum value: ");
    Console.ResetColor();
    minValue = Convert.ToInt32(Console.ReadLine());
    
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("And the maximum value: ");
    Console.ResetColor();
    maxValue = Convert.ToInt32(Console.ReadLine());
    
    userArray = GenerateArray(size, minValue, maxValue);
    
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Catch your array:");
    ShowArray(userArray);

}
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("That's all. Try again, if you want");
Console.ResetColor();

