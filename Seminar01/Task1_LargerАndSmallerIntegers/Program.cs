//Seminar 1. Task 1.

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
