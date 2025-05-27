using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            int y = (x > 0) ? ++x : x -= 2;
            Console.Write($"y = {y}");
            Console.ReadLine();
        }
    }
}
