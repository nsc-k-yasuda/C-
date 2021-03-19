using System;

namespace prob4_15
{
    class Program38
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 10 ==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write(i);
                }
            }
        }
    }
}
