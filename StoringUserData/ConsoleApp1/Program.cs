using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             * define a variable to hold your name,phone number and age
             * print variables line by line to the screen
             * define variables using var
             */

            string name = "Jovit";
            string number = "0123456789";
            int num = 0123456789;
            // the reason we cant use int is that it doesnt consider 0's at the beginning,only in the middle or at the end of the number. so we store the phone number as string.
            int age = 20;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(num);
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
