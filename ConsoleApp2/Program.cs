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
            double y=0;
            int x = int.Parse(Console.ReadLine());
            if(x>=0)
            {
                y = Math.Sqrt(x) + 2 * Math.Sin(x);
            }
            else
            {
                y = 6 - x ^ 2;
            }
            Console.Write($"y = {y}");
            Console.ReadLine();
        }
    }
}
