using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    // Delegate for arithmetic operations
    public delegate void OperationHandler(int num1, int num2);

    internal class Calculator
    {
        // Event to notify operation performed
        public event OperationHandler OperationPerformed;

        // Methods for arithmetic operations
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            OperationPerformed?.Invoke(num1, num2);
            return result;
        }

        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            OperationPerformed?.Invoke(num1, num2);
            return result;
        }

        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            OperationPerformed?.Invoke(num1, num2);
            return result;
        }

        public int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0;
            }

            int result = num1 / num2;
            OperationPerformed?.Invoke(num1, num2);
            return result;
        }
    }
}