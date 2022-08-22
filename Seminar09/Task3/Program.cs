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



