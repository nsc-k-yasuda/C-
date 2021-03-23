using System;
using System.Collections.Generic;
using System.Linq;

namespace prob5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] data = new int[10];
            int sum,avg;
            sum = 0;
            int x;
            List<int> rndlist = new List<int>();
            for (int i = 0; i < data.Length; i++)
            {
                x = rnd.Next(1,11);
                Console.Write("{0} ",data[i]=x);
                sum += data[i];
                rndlist.Add(x);
            }
            Console.WriteLine();
            int min = rndlist.Min();
            int max = rndlist.Max();
            avg = sum / data.Length;
            Console.WriteLine("最大値：" + max);
            Console.WriteLine("最小値：" + min);
            Console.WriteLine("平均値：" + avg);
        }
    }
}
