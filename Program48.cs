using System;
using System.Collections.Generic;

namespace prob5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Random rnd = new Random();
            int[] a = new int[10];
            List<int> rndlist = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-1, 101);
                Console.Write("{0} ",a[i]);
                rndlist.Add(a[i]);

                if (a[i] == 0)
                {
                    count += 1;
                }
                else if (a[i] >= 50)
                {
                    Console.WriteLine("50以上:{0}", a[i]);
                }
                else
                {
                    Console.WriteLine("50未満:{0}", a[i]);

                }
            }
            Console.WriteLine("0の個数：{0}",count);
        }
    }
}
