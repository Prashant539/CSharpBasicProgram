using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicProgram
{
    public class Calculator
    {
        /// <summary>
        /// Instance Variables
        /// </summary>
        public int first, second, sum;
        /// <summary>
        /// Sbutraction of 2 numbers to get sum
        /// </summary>
        public Calculator(int firstNumber, int secondNumer)
        {
            first = firstNumber;
            second = secondNumer;
        }
       
        public void Addition()
        {
            sum = first + second;
            Console.WriteLine("sum:" + sum);
        }
        public void Subtraction()
        {
            sum = Math.Abs(first - second);
            Console.WriteLine("Diff:" + sum);
        }



    }
}
