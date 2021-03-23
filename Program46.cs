using System;

namespace prob5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] d = new int[5];
            int sum, avg;
            sum = 0;
            for (int i = 0; i < d.Length; i++)
            {
                int a = rnd.Next(11);
                Console.Write(" {0}",d[i]=a);
                sum += d[i];
            }
            Console.WriteLine();
            avg = sum / d.Length;
            Console.WriteLine("合計値：" + sum);
            Console.WriteLine("平均値：" + avg);

            if (d > avg)
            {
                Console.WriteLine("平均値より大きい数：{0}" ,);
            }
        }
    }
}
