// TASK 1. Larger and smaller integers.
/*
Console.Write("Please, input the first integer: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input the second integer: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) 
    Console.WriteLine("The first integer is greater than the second: " + num1 + " > " + num2);
else
    if (num2 > num1)
        Console.WriteLine("The second integer is greater than the first: " + num2 + " > " + num1);
    else 
        Console.WriteLine("What a prankster you are, bro! Your integers are equal.");
*/

// TASK 2. The max of three integers.
/*
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
*/

// TASK 3. Is your number even?
/*
Console.Write("Please, input an integer: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0) 
    Console.WriteLine("Yeah! Your number is even.");
else
    Console.WriteLine("Oops... Your number is odd.");
*/

// TASK 4. All even numbers from one to N inclusive
/*
Console.Write("Please, input an integer greater than one: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;
if(num > 1)
{
    while(current <= num)
    {
        Console.Write(current + " ");
        current = current +2;
    }
}
else Console.WriteLine("Retry... Just retry.");
*/
