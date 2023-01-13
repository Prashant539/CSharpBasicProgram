using System;
namespace CSharpBasicProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CSharp Program");
            Console.WriteLine("Choose any options to perform");
            Console.WriteLine("1:Calculator");
            int options = Convert.ToInt32(Console.ReadLine());
            switch(options)
            {
                case 1:
                    break;
                default:
                    break;

            }
            
            Console.WriteLine("Please enter the First Number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Second Number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Calculator calculator = new Calculator(first, second);
            calculator.Addition();
            calculator.Subtraction();
            Console.ReadLine();
        }
    }
}
