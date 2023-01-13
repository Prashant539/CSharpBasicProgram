using System;
namespace CSharpBasicProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CSharp Program");
            Console.WriteLine("Choose any options to perform");
            Console.WriteLine("1:Calculator\n2:SwitchCase\n10:Exit");
            int options = Convert.ToInt32(Console.ReadLine());
            switch(options)
            {
                case 1:
                    Console.WriteLine("Please enter the First Number: ");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the Second Number: ");
                    int second = Convert.ToInt32(Console.ReadLine());
                    Calculator calculator = new Calculator(first, second);
                    calculator.Addition();
                    calculator.Subtraction();
                    break;
                case 2:
                    Console.WriteLine("Please choose a day number");
                    int day = Convert.ToInt32(Console.ReadLine());
                    WeekDay.FindDaysOfWeeks(day);
                    break;
                case 10:   
                default:
                    Console.WriteLine("Please choose number between 1 to 7");
                    break;

            }
            Console.ReadLine() ;
            
           

            
        }
    }
}
