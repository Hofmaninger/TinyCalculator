
Console.WriteLine("== Tiny Calculator ==");

Console.Write("Enter Operand1: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Enter Operand2: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
Console.WriteLine($"{a} / {b} = {a / b}");
