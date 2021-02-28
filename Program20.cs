using System;

namespace prob3_15
{
    class Program20
    {
        static void Main(string[] args)
        {
            Console.Write("点数(1-100)：");
            int suuji = int.Parse(Console.ReadLine());

            if (suuji <0 || suuji > 100)
            {
                Console.WriteLine("範囲外");
            }
            else if(suuji >= 80)
            {
                Console.WriteLine("優");
            }
            else if (suuji >= 70 && suuji <80)
            {
                Console.WriteLine("良");
            }
            else if (suuji < 70 && suuji >= 60)
            {
                Console.WriteLine("可");
            }
            else if(suuji < 60)
            {
                Console.WriteLine("不可");
            }
        }
    }
}
