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
double Additioned = 0;
double Subtracted = 0;
double Multiplied = 0;
double Divided = 0;
static void Addition(double num1, double num2)
{
    double Additioned = num1 * num2;
    Console.WriteLine("wow");

}
static void Subtraction()
{
    double Subtracted = 0;
}
static void Multiplication()
{

}
static void Division()
{

}
Addition(1, 2);
Console.WriteLine(Additioned);
Addition(3.64542, 4.812768);
Console.WriteLine(Additioned);

Console.WriteLine("\n");
Console.WriteLine("1. 12 + 5 = ");
Console.WriteLine("2. 902 / 72 = ");
Console.WriteLine("3. 658 * 23 = ");
Console.WriteLine("4. 5 - 72 = ");
Console.WriteLine("5. 72 * 3 / 4 = ");
Console.WriteLine("6. 17 + 42 * 76 - 19 = ");
Console.WriteLine("7. 82.7 * (52.33 * 84) - 12 / 54 = ");
Console.WriteLine("8. 3.14 * (5 * 5) * (5 / 3)");


Part3:
Console.Write("Input number: ");
try
{
    int num = 2;
    int StarNumber = int.Parse(Console.ReadLine());
    Console.WriteLine(num);
    Stars();
    Console.WriteLine(num);
    static void Stars(int num = 3)
    {
        Console.WriteLine(num);
        for (int i = 0; i >= num; i++)
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
