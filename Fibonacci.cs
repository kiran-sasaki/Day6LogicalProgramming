using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingDay6
{
    public static class Fibonacci
    {
        public static void FibSeries()
        {
            int number, n1 = 0, n2 = 1, n3, i;
            Console.WriteLine("enter the no of elements");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2);
            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.Write(" " + n3);
            }

        }
    }
}
