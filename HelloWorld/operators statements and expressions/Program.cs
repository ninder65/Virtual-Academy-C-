using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators_statements_and_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int x, y,a, b;
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //There are many different mathematical operator.
            //Addition operator
            x = 3 + 4;

            //subtration operator

            x = 4 - 3;
            //Division operator
            x = 10 / 5;
            //Multiplication operator
            x = 2 * 2;
            //order of using parenthesis
            x = (x + y) + (a - b);

            //Equaltity operator
            if (x == y) {
            }

            //Greater than operator
            if (x > y)
            {
            }
            //less than operator
            if (x < y)
            {
            }
            //Greater than equal to operator
            if (x >= y)
            {
            }


            //Conditional AND operator
            if ( (x > y) && ( a > b ) )
            {
            }
            //Conditional OR operator
            if ((x > y) || (a > b))
            {
            }



        }
    }
}
