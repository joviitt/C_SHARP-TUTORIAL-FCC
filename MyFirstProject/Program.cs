using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            Console.WriteLine("hello world");

            //data types. we can use the capital letter at the end of the declaration to specify the type it is optional
            int age;
            age = 23; //integer
            Console.WriteLine(age);

            long bigNumber = 123L; //long number
            Console.WriteLine(bigNumber);


            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            double negative = -23.45D; //double
            Console.WriteLine(negative);

            float smallNumber = 2.5F;//float
            Console.WriteLine(smallNumber);

            decimal decimalNumber = 3.5M; //decimal
            Console.WriteLine(decimalNumber);

            Console.Write("my name is : ");

            string name = "jovit"; //string must be in double quotes, can be empty
            Console.Write(name);

            Console.WriteLine();

            char letter = 'A'; //char   must be in single quotes,cannot be empty
            Console.WriteLine(letter);

            //converting string to int

            string textage = "23";
            int age2= Convert.ToInt32(textage);
            Console.WriteLine(age2);

            float floatNumber = Convert.ToSingle(textage);
            Console.WriteLine(floatNumber);
            

            //boolean

            bool isalive = true;
            Console.WriteLine(isalive);

            //operators

            age = 24;
            age++;
            age += 1;

            Console.WriteLine(age);
            


        }
    }
}
