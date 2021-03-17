using System;
using System.Linq;
using System.Collections.Generic;


namespace prob4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                i++;
                List<int> rndlist = new List<int>();
                Random rnd = new Random();
                for (int i = 1; i <= 5; i++)
                {
                    int a = rnd.Next(1, 101);
                    //Console.Write(a);
                    rndlist.Add(a);
                    if (a % 2 == 0)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(a);
                    }
                    break;
                }
            Console.WriteLine("{i}番目",i);
            }
        }
    }
}
