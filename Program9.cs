using System;

namespace prob3_4
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            if (a <=20 || a>=80)
            {
                Console.WriteLine("20以下か80以上の値です");
            }
        }
    }
}
