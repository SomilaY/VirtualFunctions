using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new Shape(4, 6);
            Rectangle rec = new Rectangle(5,6);
            Square sq = new Square(10); 

            Console.WriteLine(sh.PrintShape());
            Console.WriteLine($"Area: {sh.Area}");
            Console.WriteLine("===================");

            Console.WriteLine(rec.PrintShape());
            Console.WriteLine($"Area : {rec.Area}");
            Console.WriteLine("===================");

            Console.WriteLine(sq.PrintShape());
            Console.WriteLine($"Area: {sq.Area}");
            Console.WriteLine("===================");

            Console.ReadLine();
        }
    }
}
