// TASK 2. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// Чтобы найти точку пересечения, можно выразить y через x в одном уравнении, найти в нём x, 
// и потом в другом найти y, подставив найденный x. 
// И получается, что точка (x, y) будет точкой пересечения. Если я правильно помню))

double k1, k2, b1, b2, x, y;

Console.Write("Input the coefficient k1 of the equation y = k1 * x + b1: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coefficient b1 of the equation y = k1 * x + b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coefficient k2 of the equation y = k2 * x + b2: ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coefficient b2 of the equation y = k2 * x + b2: ");
b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.WriteLine($"Lines cross at point ({x} , {y})");
