using System;

namespace prob4_14
{
    class Program37
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 11);
            for (int i = 0; i < dice; i++)
            {
            if (dice %2 == 0)
            {
                Console.Write("★");
            }
            else
            {
                Console.Write("☆");
            }
            }
        }
    }
}
