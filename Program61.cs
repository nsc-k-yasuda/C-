using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            while (true)
            {
                int i = r.Next(11);

                Console.WriteLine($"0～10の値を出力:{i}");

                if (i == 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
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

            Console.WriteLine($"偶数:{answer(even)}");
            Console.WriteLine($"奇数:{answer(odd)}");
        }
    }
}
