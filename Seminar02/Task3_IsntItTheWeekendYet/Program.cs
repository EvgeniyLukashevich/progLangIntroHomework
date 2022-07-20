// Seminar 2. Task 3.

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