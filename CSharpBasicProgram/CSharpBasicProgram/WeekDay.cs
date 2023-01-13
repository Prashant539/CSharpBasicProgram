using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicProgram
{
    public class WeekDay
    {
        public static void FindDaysOfWeeks(int dayNumber)
        {
            switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("It is a Monday");
                    break;
                case 2:
                    Console.WriteLine("It is a Tuesday");
                    break;
                case 3:
                    Console.WriteLine("It is a Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It is a Thrusday");
                    break;
                case 5:
                    Console.WriteLine("It is a Friday");
                    break;
                case 6:
                    Console.WriteLine("It is a Saturday");
                    break;
                case 7:
                    Console.WriteLine("It is a Sunday");
                    break;
                default:
                    Console.WriteLine("Please choose number between 1 to 7 ");
                    break;

            }
        }
    }
}
