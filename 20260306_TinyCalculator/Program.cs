Console.WriteLine("== Tiny Calculator ==");

Console.Write("Enter Operand1: ");
double result = double.Parse(Console.ReadLine());

while (true)
{
    Console.Write("Enter Operator (+, -, *, /) or 'exit': ");
    string op = Console.ReadLine();

    if (op == "exit")
        break;

    Console.Write("Enter Operand2: ");
    double b = double.Parse(Console.ReadLine());

    switch (op)
    {
        case "+":
            result = result + b;
            break;
        case "-":
            result = result - b;
            break;
        case "*":
            result = result * b;
            break;
        case "/":
            if (b == 0)
            {
                Console.WriteLine("Division durch 0 nicht erlaubt!");
                continue;
            }
            result = result / b;
            break;
        default:
            Console.WriteLine("Ungültiger Operator!");
            continue;
    }

    Console.WriteLine("Ergebnis: " + result);
}