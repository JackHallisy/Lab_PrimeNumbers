using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool PrimeNum = true;
            Console.WriteLine("The Prime numbers are:  ");
            for (int ctr1 = 2; ctr1 <= 100; ctr1++)
            {
                for (int ctr2 = 2; ctr2 <= 100; ctr2++)
                {
                    if (ctr1 != ctr2 && ctr1 % ctr2 == 0)
                        {
                            PrimeNum = false;
                            break;
                        }
                }
                if(PrimeNum)
                {
                    Console.Write("  " + ctr1);
                }
                PrimeNum = true;
            }
            Console.Read();
        }
    }
}
