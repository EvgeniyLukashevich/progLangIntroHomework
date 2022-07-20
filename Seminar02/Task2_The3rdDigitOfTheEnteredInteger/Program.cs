// Seminar 2. Task 2.

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