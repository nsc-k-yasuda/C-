using System;

namespace prob3_3
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            if (a < 50)
            {
                Console.WriteLine("50未満です。");
            }
        }
    }
}
