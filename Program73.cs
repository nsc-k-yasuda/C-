using System;

namespace Problemex7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = { 0, 1, 2 };
                //  配列の内容を表示
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("a[" + i + "]=" + a[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("配列の範囲を超えています。");
            }
        }
    }
}
