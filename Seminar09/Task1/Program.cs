// TASK 1. Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

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

int m = 7, n = -10;

Console.WriteLine();
ShowRange(m, n);
Console.WriteLine();
Console.WriteLine();


