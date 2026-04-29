
// condtion switch case date type for 

// input
// string name ;
// Console.WriteLine("Enter your name");
// name = Console.ReadLine();
// // output
// Console.WriteLine("Hello " + name);


// calculater

// + - / * 

Console.WriteLine("Welcome to the calculator program!");
Console.WriteLine("======= Calculator ========");
Console.WriteLine("===================================");
Console.WriteLine("Khtar Opertion libriti");
Console.WriteLine("1. Addition (+)");
Console.WriteLine("2. Subtraction (-)");
Console.WriteLine("3. Multiplication (*)");
Console.WriteLine("4. Division (/)");
int operation;
Console.WriteLine("Enter the operation you want to perform");
operation = int.Parse(Console.ReadLine());
double x;
double y;
double result;

switch (operation)
{
    case 1:
        Console.WriteLine("Enter the first number");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        y = double.Parse(Console.ReadLine());
        result = x + y;
        Console.WriteLine("Result: = " + result);
        break;
    case 2:
        Console.WriteLine("Enter the first number");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        y = double.Parse(Console.ReadLine());
        result = x - y;
        Console.WriteLine("Result: = " + result);
        break;
    case 3:
        Console.WriteLine("Enter the first number");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        y = double.Parse(Console.ReadLine());
        result = x * y;
        Console.WriteLine("Result: = " + result);
        break;
    case 4:
        Console.WriteLine("Enter the first number");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        y = double.Parse(Console.ReadLine());
        result = x / y;
        Console.WriteLine("Result: = " + result);
        break;
}
