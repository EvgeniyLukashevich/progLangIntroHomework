// Seminar 2. Task 1.

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