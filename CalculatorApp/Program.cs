namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the calculator
            Calculator calculator = new Calculator();

            // Subscribe to the OperationPerformed event using lambda expressions
            calculator.OperationPerformed += (num1, num2) => Console.WriteLine($"Performed addition: {num1} + {num2}");
            calculator.OperationPerformed += (num1, num2) => Console.WriteLine($"Performed subtraction: {num1} - {num2}");
            calculator.OperationPerformed += (num1, num2) => Console.WriteLine($"Performed multiplication: {num1} * {num2}");
            calculator.OperationPerformed += (num1, num2) => Console.WriteLine($"Performed division: {num1} / {num2}");

            // Simple console interface
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Enter two numbers:");

            Console.Write("First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Perform arithmetic operations
            Console.WriteLine($"Addition Result: {calculator.Add(num1, num2)}");
            Console.WriteLine($"Subtraction Result: {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Multiplication Result: {calculator.Multiply(num1, num2)}");
            Console.WriteLine($"Division Result: {calculator.Divide(num1, num2)}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}