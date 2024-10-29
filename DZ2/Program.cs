Console.WriteLine("┌---------------------------------------┐");
Console.WriteLine($"|        x          |         y         |");
Console.WriteLine("|---------------------------------------|");
for (double x = -Math.PI / 5; x <= 9*Math.PI / 4; x += 0.2)
{

    double y;
    if (x > 2.5) y = Math.Sin(2.3 * x - 1);
    else if (x >= 0 && x <= 2.5) y = 1 - 3 * Math.Log(1 - x);
    else y = 2 - x;
    Console.WriteLine($"|       {x,-5:F2}       |       {y,5:F2}       |");
}
Console.WriteLine("└---------------------------------------┘");