namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Would you like to add, times, subtract or  divide?");
            string op = Console.ReadLine();
            if (op == "add"){
                double result = num1 + num2;
            }
            else if (op == "times"){
                double result = num1 * num2;
            }
            else if (op == "subtract"){
                double result = num1 - num2;
            }
            else if (op == "divide"){
                try {
                    double result = number1 / number2;
                }
                catch (DivideByZeroException) {
                    Console.WriteLine("Division of {0} by zero.", num1);
                }
            }
            Console.Write(result);
        }
    }
}