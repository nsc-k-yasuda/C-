using System;

namespace prob4_2
{
    class Program25
    {
        static void Main(string[] args)
        {
            Console.Write("数：");
            int s = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < s)
            {
                Console.Write("□ ");
                i++;
            }
            Console.WriteLine();
        }
    }
}
