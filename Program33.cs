using System;

namespace prob4_10
{
    class Program33
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(rnd.Next(101));
            }
            Console.WriteLine();
        }
    }
}
