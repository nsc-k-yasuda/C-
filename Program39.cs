using System;
using System.Text;

namespace prob4_16
{
    class Program39
    {
        static void Main(string[] args)
        {
            int val = 0;
            for (int i = 1; i <10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    val = i * j;
                    Console.Write("{0}*{1}={2} ",i,j,i*j);
                }
                Console.WriteLine();
            }
        }
    }
}
