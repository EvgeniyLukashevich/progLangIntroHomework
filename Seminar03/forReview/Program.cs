//TASK 1 vers1. Is your five-digit number a palindrome?
/*
bool FiveDigitPalindrome (int num)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10) return true;
    else return false;
}
Console.Write("Please, input your five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result;
if (num > 9999 && num < 100000)
{
    result = FiveDigitPalindrome(num);    
    if (result == true)
        Console.WriteLine($"Your number \"{num}\" is a palindrome!");
    else
        Console.WriteLine($"Your number \"{num}\" is not a palindrome... Sorry.");
}
else Console.WriteLine($"Your number is not a five-digit number. Please, try again");
*/

//TASK 1 vers2. Is your number a palindrome? (Осенило, когда на листочке записал палиндром справа налево и получил то же самое число:))) 
//Получается, что это решение не только для пятизначных чисел. И даже для однозначного - технически это тоже палиндром. Наверное))                                            
/*                                              
bool Palindrome (int num)
{
    int reverseNum = 0;
    int temp = num;
    while (temp > 0)
    {
        reverseNum = reverseNum * 10;
        reverseNum = reverseNum + temp % 10;
        temp = temp / 10;
    }
    
    if (reverseNum == num) return true;
    else return false;
}
Console.Write("Please, input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = Palindrome(num);
if (result == true)
    Console.WriteLine($"Your number \"{num}\" is a palindrome!");
else
    Console.WriteLine($"Your number \"{num}\" is not a palindrome... Sorry.");
*/

//TASK 2. The distance between two points in 3D
/*
double DistanceBtwnTwoPoints(int xa, int ya, int za, int xb, int yb, int zb)
{
    double dist = Math.Sqrt((xb-xa) * (xb-xa) + (yb-ya) * (yb-ya) + (zb-za) * (zb-za));
    return dist;
}
Console.Write("Please, input 1st point x-axis: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input 1st point y-axis: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input 1st point z-axis: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input 2nd point x-axis: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input 2nd point y-axis: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input 2nd point z-axis: ");
int zb = Convert.ToInt32(Console.ReadLine());
double dist = DistanceBtwnTwoPoints(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Your points: A({xa}, {ya}, {za}); B({xb}, {yb}, {zb})");
Console.WriteLine($"The distance between your points is {dist}");
*/

//TASK 3. Cubes from one to N 
/*(Если будет введено число меньше единицы, также выдаст кубы от единицы (включительно) до этого числа, 
так как это не противоречит условию задачи. Скорее, это даже следует из условия)*/

void Cubes(int num)
{
    int current = 1;
    Console.WriteLine($"Cubes from 1 to {num}:");
    
    if (num >= 1)
    {
        while (current <= num)
        { 
            Console.Write($"{current * current * current} ");
            current++;
        }
    }
    else
    {
        while (current >= num)
        {
            Console.Write($"{current * current * current} ");
            current--;
        }
    }
}
Console.Write("Please, input an integer: ");
int num = Convert.ToInt32(Console.ReadLine());
Cubes(num);

