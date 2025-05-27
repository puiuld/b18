using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double y;
            int x = int.Parse(Console.ReadLine());
            if (x<= -5)
            {
                y = x ^ 2 + 15 * x;

            }
            else if (x >= 5)
            {
                y = (3 * x + 1) / 5;
            }
            else
            {
                y = Math.Sqrt(13 + x);
            }
            Console.WriteLine($"y = {y:f2}");
            Console.ReadLine();

        }
    }
}
