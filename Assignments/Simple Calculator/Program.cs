namespace Simple_Calculator
{
    internal class Program
    {
        static float Calculate(int firstOperand, int secondOperand, int operationTypeNumber)
        {
            float result = default;

            if (operationTypeNumber == 1) // 1 - Add 
            {
                result = firstOperand + secondOperand;
                return result;
            }
            else if (operationTypeNumber == 2) // 2 - Substract
            {
                result = firstOperand - secondOperand;
                return result;
            }
            else if (operationTypeNumber == 3)  // 3 - Multiply
            {
                result = firstOperand * secondOperand;
                return result;
            }
            else if (operationTypeNumber == 4)  // 4- Divide
            {
                if (secondOperand != 0)
                {
                    result = (float)firstOperand / secondOperand;
                    return result;
                }
                else
                {
                    throw new Exception("You can't divide by Zero !");
                }
            }
            else
            {
                throw new Exception("Invalid Operation Type ! ");
            }
        }
        static void Main(string[] args)
        {
            //  1.Write a program that represents a simple calculator that has the following Operations:
            //-Add, Subtract, Multiply, Divide
            //User should enter the two operands and the type of operation he wants.

            Console.Write("Enter the first operand : ");
            int firstOperand = int.Parse(Console.ReadLine());

            Console.Write("Enter the second operand : ");
            int secondOperand = int.Parse(Console.ReadLine());     

            Console.WriteLine("1 - Add ");
            Console.WriteLine("2 - Substract ");
            Console.WriteLine("3 - Multiply ");
            Console.WriteLine("4 - Divide ");

            Console.Write("Enter the number of operation : ");
            int operationTypeNumber = int.Parse(Console.ReadLine());

            float result = Calculate(firstOperand, secondOperand, operationTypeNumber);

            Console.WriteLine($"The result of this operation is : {result}");
        }
    }
}
