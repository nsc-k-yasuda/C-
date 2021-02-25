using System;

namespace prob3_12
{
    class Program17
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("正の値です。");
            }else if (num < 0)
            {
                Console.WriteLine("負の値です。");
            }
            else if (num == 0)
            {
                Console.WriteLine("0です。");
            }
        }
    }
}
