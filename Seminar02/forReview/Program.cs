// TASK 1. The 2nd digit of a three-digit integer
/*
int SecondDigitSearch(int num)  
{
    int secDigit = (num / 10) % 10;
    return secDigit;
}
Console.Write("Please, input a positiv three-digit integer: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99 && num < 1000)
{
    int secondDigit = SecondDigitSearch(num);
    Console.WriteLine($"The second digit of {num} is {secondDigit}");
}
else
    Console.WriteLine("Try again. Your number doesn't match what you were asked to enter");
*/

// TASK 2. The 3rd digit of the entered integer
/*
int ThirdDigitSearch(int num)
{
    while(num > 999)
        num = num / 10;
    return num % 10; 
}
Console.Write("Please, input a positiv integer: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{
    int thirdDigit = ThirdDigitSearch(num);
    Console.WriteLine($"The third digit of {num} is {thirdDigit}");
}
else
{
    Console.WriteLine("There is no third digit in your number");
    Console.WriteLine("It's also possible that your number is negative. But you wouldn't do that... would you?");
}
*/

// TASK 3. Isn't it the weekend yet?
/*
bool WeekendIdentify(int num)
{
    if (num > 5)
        return true;
    else
        return false;
}
Console.Write("Please, input the number of the day of the week you are interested in: ");
int num = Convert.ToInt32(Console.ReadLine());
bool weekend = WeekendIdentify(num);
if (num > 0 && num < 8)
{
    if (weekend == true)
        Console.WriteLine("Yeah! Your day is a day off!");
    else
        Console.WriteLine("Sorry, it's a weekday");        
}
else
{
    Console.WriteLine("There are only seven days of the week");           // Просто хотелось так написать))
    Console.WriteLine("Try again and input a number from one to seven");  // А разделил на два РайтЛайна, чтобы строка вывода не была слишком длинной :)
}
*/