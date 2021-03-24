using System;
using System.Collections.Generic;
using System.Linq;

namespace prob5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[10];
            List<int> rndlist = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 101);
                Console.Write(a[i] + " ");
                rndlist.Add(a[i]);
                if (a[i] >= 50)
                {
                    Console.WriteLine("50以上:{0}",a[i]);
                }
                else
                {
                    Console.WriteLine("50未満:{0}", a[i]);
                }
            }
            Console.WriteLine();     
        }
    }
}
