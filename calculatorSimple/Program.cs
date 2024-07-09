//doWhile case for restarting app
do
{
    //Header
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("-----------");
    Console.WriteLine("Calculator");
    Console.WriteLine("-----------");
    //Declaring needed variables
    double num1 = 0;
    double num2 = 0;
    double result = 0;
    //Inputing operational numbers
    Console.WriteLine("Input first number: ");
    Console.ForegroundColor = ConsoleColor.Green;
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Input second number: ");
    Console.ForegroundColor = ConsoleColor.Green;
    num2 = Convert.ToDouble(Console.ReadLine());
    //Selecting operational function 
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Choose a function: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\t+  Add");
    Console.WriteLine("\t-  Subtract");
    Console.WriteLine("\t*  Multiply");
    Console.WriteLine("\t/  Divide");
    Console.ForegroundColor = ConsoleColor.Green;
    //Switch case returning respective results, based on selected function
    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Result: {num1} + {num2} = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Result: {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Result: {num1} * {num2} = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Result: {num1} / {num2} = " + result);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Invalid function!");
            break;
    }
    //Request to continue
    Console.WriteLine("Would you like to continue? (Y/N): ");
    Console.ForegroundColor = ConsoleColor.Green;
 //Restarting app in case of approval
} while (Console.ReadLine().ToUpper() == "Y");
Console.ForegroundColor = ConsoleColor.Red;
 //Closing app in case of rejection
    Console.Write("Exiting...");
Console.ForegroundColor = ConsoleColor.Cyan;

