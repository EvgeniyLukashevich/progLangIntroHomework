// Seminar 3. Task 3.

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