using System;

namespace prob5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 101);
                Console.Write("{0} ", a[i]);
            }

            //    Random r = new Random();
            //    int[] data = new int[10];

            //    for (int i = 0; i < 10; i++)
            //    {
            //        data[i] = r.Next(100) + 1;
            //        Console.Write("{0} ", data[i]);
            //    }

            //    Console.Write("\r\n\r\n奇数：");
            //    for (int i = 0; i < 10; i++)
            //        if (data[i] % 2 != 0) Console.Write("{0} ", data[i]);
            //    Console.Write("\r\n偶数：");
            //    for (int i = 0; i < 10; i++)
            //        if (data[i] % 2 == 0) Console.Write("{0} ", data[i]);
            //}
        }
    }
}
