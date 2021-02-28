using System;

namespace prob3_16
{
    class Program21
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力：");
            int seisuu = int.Parse(Console.ReadLine());

            if (seisuu % 2 == 0 && seisuu % 3 == 0)
            {
                Console.WriteLine("2と3の公倍数です。");
            }
            else if (seisuu % 2 == 0)
            {
                Console.WriteLine("2の倍数です。");
            }else if (seisuu % 3 == 0)
            {
                Console.WriteLine("3倍数です。");
            }
        }
    }
}
