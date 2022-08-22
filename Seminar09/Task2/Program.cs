// TASK 2. Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

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



