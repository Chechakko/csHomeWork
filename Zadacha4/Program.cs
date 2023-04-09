Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Enter second numer: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Enter third number: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);