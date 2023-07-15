//Поиск расстояния в 3D пространстве
double LineLengtABC(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengtAB = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) + (z2 - z1));
    //int deltaX = x2 - x1; Math.Sqrt(deltaX * deltaX)
    return lengtAB;
}

Console.WriteLine("Enter x coord A");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y coord A");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z coord A");
int zAcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter x coord B");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y coord B");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z coord B");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double dist = LineLengtABC(xAcoord, xBcoord, yAcoord, yBcoord, zAcoord, zBcoord);
Console.WriteLine($"Distance ABC is {dist:f3}");