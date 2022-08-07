// TASK 1. Raise the integer A to the power B
/*
int Exponentiation(int num, int degree)
{
    int result = 1;
    
    for (int count = 1; count <= degree; count++)   // При степени равной нулю, не пойдёт по циклу 
        result *= num;                              // и просто вернёт result равный единице
    
    return result;
}

Console.Write("Please, input your integer: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input the natural degree to which you want to raise your integer: ");
int userDegree = Convert.ToInt32(Console.ReadLine());

if (userDegree >= 0)
{
    int result = Exponentiation(userNum, userDegree);
    Console.WriteLine($"{userNum} to the {userDegree} power is {result}");
}
else
    Console.WriteLine("You need to input a natural number as a power. Try again and don't mess around anymore! ;)");
*/


// TASK 2. The sum of the digits of a number
/*
int SumOfDigits1(int num)
{
    int result = 0;
    
    while (num != 0)
    {
        result = result + num %10;
        num /= 10;
    }
    
    if (result >= 0) return result;
    else return result * -1;          
}

int SumOfDigits2(int num)       // По сути, точно такой же метод. Не знаю какую запись считать предпочтительне:)
{
    int result = 0;
    
    for ( ; num != 0; num /=10)
    {
        result = result + num %10;
    }
    
    if (result >= 0) return result;
    else return result * -1;
}

Console.Write("Please, input your integer: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int ssum = SumOfDigits2(userNum);

Console.WriteLine($"The sum of the digits of {userNum} is {ssum}");
*/



// TASK 3. An array of eight elements
// Конечно, задача в разы короче, но я хотел попробовать немного повзаимодействовать с пользователем :))
// И попробавать немного цвета применить, чтобы всё не сливалось в общую массу текста в терминале

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

