using System;

namespace prob3_4
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            if (a >30 || a<=70)
            {
                Console.WriteLine("30より大きく70以下です");
            }
        }
    }
}
