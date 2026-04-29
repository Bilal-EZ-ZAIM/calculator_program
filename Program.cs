
// condtion switch case date type for 

// input
// string name ;
// Console.WriteLine("Enter your name");
// name = Console.ReadLine();
// // output
// Console.WriteLine("Hello " + name);


// calculater

// + - / * 


// int x = 5;

// 5  5+1 6 6+1 7 7+1 8 8+1 9 9+1 10


// while (x < 10)
// {
//     Console.WriteLine("X rah As4ar mn 10");
//     Console.WriteLine("X = " + x);
//     x++;
// }

Console.WriteLine("Welcome to the calculator program!");
Console.WriteLine("======= Calculator ========");
Console.WriteLine("===================================");
Console.WriteLine("Khtar Opertion libriti");
Console.WriteLine("1. Addition (+)");
Console.WriteLine("2. Subtraction (-)");
Console.WriteLine("3. Multiplication (*)");
Console.WriteLine("4. Division (/)");
Console.WriteLine("0 . Exit");
int operation;
double x;
double y;
double result;
do
{

    Console.WriteLine("Enter the operation you want to perform");
    operation = int.Parse(Console.ReadLine());
    switch (operation)
    {
        case 1:
            Console.WriteLine("Result: = " + sum());
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
} while (operation != 0);

double sum()
{
    Console.WriteLine("Enter the first number");
    x = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    y = double.Parse(Console.ReadLine());
    result = x + y;
    return result;
}
// type name(){
// return type
// }

// int number()
// {
//     Console.WriteLine("Enter a number");
//     int x = int.Parse(Console.ReadLine());
//     return x;
// }

// Console.WriteLine("The number you entered is: " + number());


