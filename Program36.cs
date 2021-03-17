
using System;

namespace prob4_13
{
    class Program36
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 1; i++)
            {
                int a = rnd.Next(1, 11);
                //Console.Write(a);
                if(a >= 5)
                {
                    Console.WriteLine("★ ");
                }
                else
                {
                    Console.WriteLine("発生した数値：",a);
                    Console.Write("☆ ");
                }
            }
        }
    }
}
