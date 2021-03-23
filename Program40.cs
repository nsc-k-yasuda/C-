using System;

namespace prob5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[7];
            int s=-1;
            for (int i = 0; i < a.Length; i++)
            {
                int dice = rnd.Next(1, 11);
                s = s + 1;
                Console.Write(" a[{0}]={1} ",s,dice);
            }
        }
    }
}
