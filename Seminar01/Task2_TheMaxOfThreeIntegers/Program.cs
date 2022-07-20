// Seminar 1. Task 2.

Console.Write("Please, input the first integer: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input the second integer: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input the third integer: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num1 == num2 || num1 == num3 || num2 == num3) 
    Console.WriteLine("Try to input the numbers so that they don't repeat, bro. Don't give up.");
else
{
    if(num2 > max) max = num2;
    if(num3 > max) max = num3;
    Console.WriteLine("The max of your three integers is " + max);
}
