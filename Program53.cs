﻿using System;

namespace prob6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMax m = new MinMax();
            int a = 4, b = 2, c=10;
            Console.WriteLine("{0}と{1}と{2}のうち、最大のものは{3}", a, b, c, m.Max(a, b, c));
            Console.WriteLine("{0}と{1}と{2}のうち、最小のものは{3}", a, b, c, m.Min(a, b, c));
        }
    }
}
