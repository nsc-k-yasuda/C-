using System;

namespace prob3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力してください(1-100)：");
            int seisuu = int.Parse(Console.ReadLine());

            if(seisuu < 0 || seisuu > 100)
            {
                Console.WriteLine("適切な値を入力してください。");
            }else if (seisuu <= 50)
            {
                Console.WriteLine("50以下です。");
            }else if(seisuu %2 == 0)
            {
                Console.WriteLine("偶数です。");
            }else if (seisuu <= 50 && seisuu % 2 == 0)
            {
                Console.WriteLine("50以下の偶数です。");
            }
        }
    }
}
