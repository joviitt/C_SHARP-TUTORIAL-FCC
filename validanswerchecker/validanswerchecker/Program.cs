using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validanswerchecker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first number: ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the second number: ");
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            int answer = firstnumber * secondnumber;

            Console.Write("Value of" + firstnumber + "*" + secondnumber + ": ");
            int ipanswer = Convert.ToInt32(Console.ReadLine());

            if (answer == ipanswer)
            {
                Console.WriteLine("You are correct");
            }
            else
            {
                Console.WriteLine("your are wrong");
            }



        }
    }

}
