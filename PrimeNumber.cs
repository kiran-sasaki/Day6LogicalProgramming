using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingDay6
{
    public static class PrimeNumber
    {
        public static void PrimeCheck()
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int IsPrime = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    IsPrime = 1;
                    break;
                }
            }
            if (IsPrime == 0)
            {
                Console.Write("Number is Prime.");
            }

        }
    }
}
