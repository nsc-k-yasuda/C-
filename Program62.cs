using System;
using System.Collections.Generic;

namespace probex6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<int> list = new List<int>();

            while (true)
            {
                int i = r.Next(11);

                Console.WriteLine($"0～10の値を出力:{i}");

                if (i == 0)
                {
                    break;
                }
                list.Add(i);
                list.Reverse();
            }

            string answer(List<int> data)
            {
                string ans = string.Empty;

                for (int i = 0; i < data.Count; i++)
                {
                    ans += data[i];

                    if (i < data.Count - 1)
                    {
                       ans += ' ';
                    }
                }

                return ans;
            }

            Console.WriteLine($"奇数:{answer(list)}");
            Console.ReadKey();
        }
    }
}
