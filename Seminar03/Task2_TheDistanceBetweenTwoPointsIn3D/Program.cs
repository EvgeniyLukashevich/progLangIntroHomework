// Seminar 3. Task 2.

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