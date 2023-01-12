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
        public int first, second, sub;
        /// <summary>
        /// Sbutraction of 2 numbers to get sub
        /// </summary>
        public Calculator(int firstNumber, int secondNumer)
        {
            first = firstNumber;
            second = secondNumer;
        }
       
        public void Subtraction()
        {
            sub = first - second;
            Console.WriteLine("sub:" + sub);
        }
           

    }
}
