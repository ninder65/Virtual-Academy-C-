using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int [5];
            a[0] = 3;
            a[1] = 3;
            a[2] = 3;
            a[3] = 3;

            Console.WriteLine(a[1]);
            Console.WriteLine(a.Length);
        

            int[] numbers = new int[] { 2, 3, 4, 5, 5, 4 };
            string[] names = new string[] {"Alex","Rahul","Potato" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            
            string zig = "you can get what you want if you help other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigchar in charArray)
            {
                Console.WriteLine(zigchar);
            }
            Console.ReadLine();

        }
    }
}
