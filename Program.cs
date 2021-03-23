using System;

namespace prob5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = new double[4];
            d[0] = 0.2;
            d[1] = -5.1;
            d[2] = 3.2;    //  変数の代入
            d[3] = 1.8;
            int suuji = -1;
            for (int i = 0; i < d.Length; i++)
            {
                suuji += 1;
                Console.Write(" d[{0}]={1} ",suuji , d[i]);
            }
            Console.WriteLine();
        }
    }
}
