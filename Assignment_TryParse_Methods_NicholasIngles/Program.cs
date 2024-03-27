// See https://aka.ms/new-console-template for more information


    DownArrow();
    UpArrow();
    Console.WriteLine("XXXXXXXXX");
    DownArrow();
    UpArrow();

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