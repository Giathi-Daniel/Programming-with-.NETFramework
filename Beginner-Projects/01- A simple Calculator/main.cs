using System;

namespace CalculatorApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            console.WriteLine("Enter operator (+, -, *, /)");
            string oper = Console.ReadLine();

            Console.WriteLine("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            int Result = 0;
            switch(oper) {
                case '+':
                    Result = num1 + num2;
                    break;
                case '-':
                    Result = num1 - num2;
                    break;
                case '*': 
                    Result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0) {
                        Result = num1 / num2;
                    } else {
                        Console.WriteLine("Error: Invalid. Division by zero!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid Operator")
                    return;
            }
            Console.WriteLine("Result " + Result)
        }
    }
}