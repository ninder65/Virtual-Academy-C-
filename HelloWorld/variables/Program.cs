using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
             int x;
                int y;
                x = 7;
                y = x + 3;
                Console.WriteLine(y);

                string myFirstName, myLastName;
                Console.WriteLine("What is your firstname?");
                Console.Write("Type your firstname:");
                myFirstName = Console.ReadLine();

                Console.WriteLine("What is your Lastname?");
                Console.Write("Type your Lastname:");
                myLastName = Console.ReadLine();

                Console.WriteLine("Hello," + myFirstName + " " + myLastName);

                Console.ReadLine();

            }
        }
    }

