// TASK 1. Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// Как указано в условии задачи, метод, в любом случае, будет показывать числа, начиная с М

/*
void ShowRange(int m, int n)        
{
    if (n > m)
    {
        ShowRange(m, n - 1);
        Console.Write($"{n} ");
    }

    if (m > n)
    {
        Console.Write($"{m} ");
        ShowRange(m - 1, n);
    }

    if (m == n) Console.Write($"{m} ");
}

int m = 15, n = 1;

Console.WriteLine();
ShowRange(m, n);
Console.WriteLine();
Console.WriteLine();
*/


// TASK 2. Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int RangeSum(int m, int n)
{
    if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }

    if (m != n) return m + RangeSum(m + 1, n);

    return m;
}

int m = 1, n = 20;

Console.WriteLine();
Console.WriteLine($"The sum of numbers in range from {m} to {n} is {RangeSum(m, n)}");
Console.WriteLine();
*/


// TASK 3. Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;

    if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);

    if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));

    return -1;
}

int m = 1, n = 3;

if (m < 0 || n < 0)
{
    Console.WriteLine();
    Console.WriteLine("Try again. The numbers must be positive");
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine($"M = {m}, N = {n}. Result = {AckermannFunction(m, n)}");
Console.WriteLine();


