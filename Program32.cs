using System;

namespace prob4_9
{
    class Program32
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                int dice = rnd.Next(1, 101);
                Console.WriteLine(dice);
                if (dice % 10 ==0)
                {
                    break;      //  ループから抜ける
                }
            }
            Console.WriteLine("終了します");
        }
    }
}
