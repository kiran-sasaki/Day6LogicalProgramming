using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingDay6
{
    public static class ReverseNo
    {
        public static void ReversedNo()
        {
            Console.WriteLine("enter a Number");
            int num = int.Parse(Console.ReadLine());
            int rev = 0;
            while (num > 0)
            {
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;
            }
            Console.WriteLine("the ReversedNo is: " + rev);
        }
    }
}
