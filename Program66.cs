using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            List<int> even = new List<int>();
            
            while (true)
            {
                int i = r.Next(11);

                Console.WriteLine($"0～10の値を出力:{i}");

                if (i == 0)
                {
                    break;
                }
                even.Add(i);
                if (even.Contains(2))
                {
                    even.RemoveAt(2);
                }
            }
            foreach (int s in even)
            {
                Console.Write("{0} ",s);
            }
        }
    }
}
