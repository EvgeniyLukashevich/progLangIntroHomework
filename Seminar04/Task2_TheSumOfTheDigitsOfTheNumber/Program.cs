// TASK 2. The sum of the digits of a number

int SumOfDigits1(int num)
{
    int result = 0;
    
    while (num != 0)
    {
        result = result + num %10;
        num /= 10;
    }
    
    if (result >= 0) return result;
    else return result * -1;          
}

int SumOfDigits2(int num)
{
    int result = 0;
    
    for ( ; num != 0; num /=10)
    {
        result = result + num %10;
    }
    
    if (result >= 0) return result;
    else return result * -1;
}

Console.Write("Please, input your integer: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int ssum = SumOfDigits2(userNum);

Console.WriteLine($"The sum of the digits of {userNum} is {ssum}");
