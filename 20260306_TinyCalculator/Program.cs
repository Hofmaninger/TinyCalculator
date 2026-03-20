
Console.WriteLine("== Tiny Calculator ==");

Console.Write("Enter Operand1: ");
Console.ForegroundColor = ConsoleColor.Red;
double a = double.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Enter Operand2: ");
Console.ForegroundColor = ConsoleColor.Red;
double b = double.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
Console.WriteLine($"{a} / {b} = {a / b}");
if(b == 0)
{
    Console.WriteLine($"{a} / {b} = undefiniert/unendlich");
}
else
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}