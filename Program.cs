using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disceret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" start value =  ");

            int start = int.Parse(Console.ReadLine());

            Console.WriteLine(" end value =  ");

            int end = int.Parse(Console.ReadLine());



            for (int i = start; i <= end; i++)
            {
                int x = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        x++;
                        break;
                    }


                }
                if (x == 0 && i != 1)
                    Console.WriteLine("{0}", i);
            }
        }
    }
}
