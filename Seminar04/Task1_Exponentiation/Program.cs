// TASK 1. Raise the integer A to the power B

int Exponentiation(int num, int degree)
{
    int result = 1;
    
    for (int count = 1; count <= degree; count++)   // При степени равной нулю, не пойдёт по циклу 
        result *= num;                              // и просто вернёт result равный единице
    
    return result;
}

Console.Write("Please, input your integer: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input the natural degree to which you want to raise your integer: ");
int userDegree = Convert.ToInt32(Console.ReadLine());

if (userDegree >= 0)
{
    int result = Exponentiation(userNum, userDegree);
    Console.WriteLine($"{userNum} to the {userDegree} power is {result}");
}
else
    Console.WriteLine("You need to input a natural number as a power. Try again and don't mess around anymore! ;)");

