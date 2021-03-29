using System;
using System.Collections.Generic;
using System.Collections;
namespace probex6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            var even = new ArrayList();
            var odd = new ArrayList();

            while (true)
            {
                int i = r.Next(101);

                Console.WriteLine($"0～100の値を出力:{i}");

                if (true)
                {
                    break;
                }

                if (i % 10)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }

                even.Add(i);
                
            }

            static string answer(ArrayList data)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                    for (int j = 1; j <= i + 1; j++)
                    {
                        Console.WriteLine($"    {j}桁目: {Digit(list[i], j)}");
                    }
                }


            }

            Console.WriteLine($"偶数:{answer(even)}");

            Console.ReadKey();
        }
    }
}
