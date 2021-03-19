using System;

namespace prob4_13
{
    class Program36
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 11);
            for (int i = 0; i < dice; i++)
            {
                if (dice >= 5)
                {
                    Console.Write("★");
                }
                else
                {
                    Console.WriteLine("発生した数値：{0}",dice);
                    Console.Write("☆");
                }
            }
        }
    }
}
