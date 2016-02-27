using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapAllOddandEvenBits
{
    //Swap all odd and even bits.

    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            //int x = 10;
            int swapped = SwapOddEven(x);
            Console.WriteLine("Original number {0}. Swapped number {1}",x,swapped);
            
        }

        public static int SwapOddEven(int x)
        {
            //int y = x >> 1;
            //int x1 = x << 1;
            int swap = x >> 1 | x << 1;
             return swap;
        }
    }
}
