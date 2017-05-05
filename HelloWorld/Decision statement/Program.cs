using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bobs big give away");
            Console.Write("Please choose the door:1,2 or 3");
            string userValue = Console.ReadLine();
            if (userValue == "1")
            {
                string message = "You won a new car";
                Console.WriteLine(message);

            }
            else if (userValue == "2")
            {
                string message = "You won a new Boat.";
                Console.WriteLine(message);

            }
            else if (userValue == "3")
            {
                string message = "You won a new cat";
                Console.WriteLine(message);

            }
            else {
                string message = "Sorry! we did not understand.";
                Console.WriteLine(message);

            }
            */



            Console.WriteLine("Bobs big give away");
            Console.Write("Please choose the door:1,2 or 3");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "Boat" : "stand of lint";
            //Console.Write("You won");
            //Console.Write(message);
            //Console.Write(".");
            Console.Write("You entered {0} therefore you won a {1}",userValue ,message);

            Console.ReadLine();
        }
    }
}
