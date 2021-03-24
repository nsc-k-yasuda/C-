using System;
using System.Collections.Generic;
using System.Linq;

namespace prob5_5
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
                if (a[i] % 3 ==0)
                {
                    Console.WriteLine("3の倍数：{0} ", a[i]);
                }
                else
                {
                    Console.WriteLine("3の倍数以外の数：{0}", a[i]);
                }
            }
        }
    }
}
