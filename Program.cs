using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            double a = 4.1, b = 2.3;
            double d = c.Add(a, b);
            double e = c.Sub(a, b);
            double f = c.Mul(a, b);
            double g = c.Div(a, b);
            Console.WriteLine(a + " + " + b + " = " + Math.Round(d,0, MidpointRounding.AwayFromZero));
            Console.WriteLine(a + " - " + b + " = " + Math.Round(e, 0, MidpointRounding.AwayFromZero));
            Console.WriteLine(a + " * " + b + " = " + Math.Round(f, 2, MidpointRounding.AwayFromZero));
            Console.WriteLine(a + " / " + b + " = " + Math.Round(g, 14, MidpointRounding.AwayFromZero));
        }
    }
}
