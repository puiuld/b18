using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            
            if (x > 0)
            {
                ++x;
            }
            if (x < 0)
            {
                x -= 2;
            }
            if(x == 0)
            {
                x = 10;
            }
            Console.Write($"x = {x}");
            Console.ReadLine();

        }
    }
}
