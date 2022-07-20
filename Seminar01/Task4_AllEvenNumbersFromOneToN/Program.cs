// Seminar 1. Task 4.

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