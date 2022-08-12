// TASK 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 

int GreaterThanZero(int count)
{
    int result = 0;
    int num;

    for (int current = 1; current <= count; current++)
    {
        Console.Write($"Input the {current} number of {count}: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0) result++;
    }

    return result;
}

int count = 5;
int result = GreaterThanZero(count);

Console.WriteLine();
Console.WriteLine($"There are {result} greater than zero numbers among the numbers you input");
Console.WriteLine();
