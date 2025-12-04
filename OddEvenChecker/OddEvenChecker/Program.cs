using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //using if else to check even or odd number
            int num1 = 10;
            
            if (num1%2==0)
            {
                Console.WriteLine(num1+" is an Even Number");

            }
            else
            {
                Console.WriteLine("It is an Odd Number");
            }

            // using modulus operator to check even or odd number and just simply printing the remainder

            int number1 = 7;
            int remainder = number1 % 2;

            Console.WriteLine(remainder);

            number1 = 8;
            remainder = number1 % 2;

            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
