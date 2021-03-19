using System;
using System.Linq;
using System.Collections.Generic;


namespace prob4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 101);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(dice);
            }
                for(int j = 0; j <dice; j++)
                if (dice % 2 == 0)
                {
                    Console.Write("偶数の数：");
                }
                else
                {
                    Console.Write("奇数の数：");
                }
        }
    }
}
