using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_IP_OP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            Console.Write("Enter your Age: ");
            string ageinput = Console.ReadLine();
            int age = Convert.ToInt32(ageinput);

            Console.WriteLine(); // adds a space between lines

            Console.Write("Your name is "+name+" and your age is "+age);
            Console.WriteLine();

            //strings can only use the == sign when comparing to other strings because they are text
            if (age>=18 && age<=25)
            {
                Console.WriteLine("you are between 18 and 25");
            }
            else
            {
                Console.WriteLine("you are above 25");
            }
                Console.ReadLine();
        }
    }
}
