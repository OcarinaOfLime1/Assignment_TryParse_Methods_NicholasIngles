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
static void Addition(double add1, double add2)
{
    double Added = add1 + add2;
    Console.Write(Math.Round(Added,2));
}
static void Subtraction(double sub1, double sub2)
{
    double Subtracted = sub1 - sub2;
    Console.Write(Math.Round(Subtracted,2));
}
static void Multiplication(double multi1, double multi2)
{
    double Multiplied = multi1 * multi2;
    Console.Write(Math.Round(Multiplied,2));
}
static void Division(double divi1, double divi2)
{
    double Divided = divi1 / divi2;
    Console.Write(Math.Round(Divided,2));
}

Console.Write("\n1. 12 + 5 = ");
Addition(12, 5);
Console.Write("\n2. 902 / 72 = ");
Division(902, 72);
Console.Write("\n3. 658 * 23 = ");
Multiplication(658, 23);
Console.Write("\n4. 5 - 72 = ");
Subtraction(5, 72);
Console.Write("\n5. 72 * 3 / 4 = ");
Division(72 * 3, 4);
Console.Write("\n6. 17 + 42 * 76 - 19 = ");
Multiplication(17 + 42, 76 - 19);
Console.Write("\n7. 82.7 * (52.33 * 84) - 12 / 54 = ");
Subtraction(82.7 * (52.33 * 84), 12 / 54);
Console.Write("\n8. 3.14 * (5 * 5) * (5 / 3) = ");
Multiplication(14 * (5 * 5), 5 / 3);


LayoutSelect:
Console.WriteLine("\n\n1. Row");
Console.WriteLine("2. Column");
Console.WriteLine("3. Row apart");
Console.WriteLine("4. Column apart");
Console.Write("Select star layout: ");
string LayInput = Console.ReadLine();
int NumInput = 0;
bool ParseInput = false;

switch (LayInput)
{
    case "1":
    NumberSelect1:
        NumInput = 0;
        Console.Write("\nInput number: ");
        ParseInput = int.TryParse(Console.ReadLine(), out NumInput);
        if (ParseInput)
        {
            StarsRow(NumInput);
        }
        else
        {
            Console.WriteLine("\nInvalid input, try again");
            goto NumberSelect1;
        }
        break;
    case "2":
    NumberSelect2:
        NumInput = 0;
        Console.Write("\nInput number: ");
        ParseInput = int.TryParse(Console.ReadLine(), out NumInput);
        if (ParseInput)
        {
            StarsColumn(NumInput);
        }
        else
        {
            Console.WriteLine("\nInvalid input, try again");
            goto NumberSelect2;
        }
        break;
    case "3":
    NumberSelect3:
        NumInput = 0;
        Console.Write("\nInput number: ");
        ParseInput = int.TryParse(Console.ReadLine(), out NumInput);
        if (ParseInput)
        {
            StarsRowApart(NumInput);
        }
        else
        {
            Console.WriteLine("\nInvalid input, try again");
            goto NumberSelect3;
        }
        break;
    case "4":
    NumberSelect4:
        NumInput = 0;
        Console.Write("\nInput number: ");
        ParseInput = int.TryParse(Console.ReadLine(), out NumInput);
        if (ParseInput)
        {
            StarsColumnApart(NumInput);
        }
        else
        {
            Console.WriteLine("\nInvalid input, try again");
            goto NumberSelect4;
        }
        break;
    default:
        Console.WriteLine("\nInvalid input, try again");
        goto LayoutSelect;
        break;
}
static void StarsRow(int StarAmount)
{
    Console.WriteLine("\n");
    for (int i = 0; i < StarAmount; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine("\n");
}
static void StarsColumn(int StarAmount)
{
    Console.WriteLine("\n");
    for (int i = 0; i < StarAmount; i++)
    {
        Console.WriteLine("*");
    }
    Console.WriteLine("\n");
}
static void StarsRowApart(int StarAmount)
{
    Console.WriteLine("\n");
    for (int i = 0; i < StarAmount; i++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("\n");
}
static void StarsColumnApart(int StarAmount)
{
    Console.WriteLine("\n");
    for (int i = 0; i < StarAmount; i++)
    {
        Console.WriteLine("*\n");
    }
    Console.WriteLine("\n");
}