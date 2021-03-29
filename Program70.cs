using System;
using System.Collections.Generic;
using System.Linq;

namespace probex6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            int b = 0;
            //  ハッシュセットの生成
            HashSet<int> t = new HashSet<int>();
            for (int i = 0; i <= 10; i++)
            {
                b = a.Next(1, 11);

            Console.Write("乱数: {0} ",b);
                t.Add(b);
            }
            Console.WriteLine();
            //データの出力
            foreach (int i in t)
            {
                Console.Write("出現した数: {0}", i);
            }
        }
    }
    
}
