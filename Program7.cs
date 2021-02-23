using System;

namespace prob3_2
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            if (a != 4)
            {
                Console.WriteLine("4ではありません。");
            }
        }
    }
}
