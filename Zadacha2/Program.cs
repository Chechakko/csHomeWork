Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine()!);

int min = a;
int max = b;
if (a > b)
{
    min = b;
    max = a;
}
Console.Write("Minumum number: ");
Console.WriteLine(min);
Console.Write("Maximum number: ");
Console.WriteLine(max);