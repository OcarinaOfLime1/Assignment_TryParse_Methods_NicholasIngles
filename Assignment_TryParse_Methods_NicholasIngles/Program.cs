// See https://aka.ms/new-console-template for more information

HourGlass();
static void DownArrow()
{
    Console.WriteLine("*********");
    Console.WriteLine(" ******* ");
    Console.WriteLine("  *****  ");
    Console.WriteLine("   ***   ");
    Console.WriteLine("    *    ");
}
static void UpArrow()
{
    Console.WriteLine("    *    ");
    Console.WriteLine("   ***   ");
    Console.WriteLine("  *****  ");
    Console.WriteLine(" ******* ");
    Console.WriteLine("*********");
}
static void XLine()
{
    Console.WriteLine("XXXXXXXXX");
}
static void HourGlass()
{
    DownArrow();
    UpArrow();
    XLine();
    DownArrow();
    UpArrow();
}
Part3:;
Console.Write("Input number: ");
try
{
    int StarNumber = int.Parse(Console.ReadLine());
    static void Stars(StarNumber);
{
    for (int i = 0; i == StarNumber; i++)
    {
        Console.WriteLine("*");
    }
}
}
catch
{
    Console.WriteLine("Invalid input, try again.");
    goto Part3;
}
